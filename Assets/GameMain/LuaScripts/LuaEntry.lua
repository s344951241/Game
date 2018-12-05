
LuaEntry= {}
function LuaEntry:OnStart()
	self.package = {}
	for key,_ in pairs(package.loaded) do
		if key~="LuaEntry" then
			self.package[key] = true
		end
	end 
	self.Global = {}
	for key,_ in pairs(_G) do
		self.Global[key] = true
	end

	self.modules = {}
	self.lateUpdateForms = {}
	self.updateObjs = {}
	self.updateObjs_new = {}
	require "Utility/InitUtility"
	require "Hotfix/InitHotfix"
	require "LuaObject/LuaObject"
	require "LuaObject/LuaObjectPool"
	require "Module/ModuleBase"
	require "Procedure/ProcedureBase"

	self:RegisterModule("ModuleOne","Module/ModuleOne")
	self:RegisterModule("ProcedureModule","Module/ProcedureModule")
end 
function LuaEntry.FindUpdateObj(obj)
	local objs = LuaEntry.updateObjs
	for i = 1, #objs do
		if objs[i] == obj then
			return i
		end
	end	
end
function LuaEntry:OnUpdate(deltaTime,unscaledDeltaTime)
	local objs = LuaEntry.updateObjs
	local objsNew = LuaEntry.updateObjs_new
	local numNew = #objsNew
	if numNew>0 then
		local FindUpdateObj = LuaEntry.FindUpdateObj
		for i=1,numNew do
			local item = objsNew[i]
			local index = FindUpdateObj(item.obj)
			if item.type==1 and index==nil then
				table.insert(objs,item.obj)
			elseif item.type==0 and index~=nil then
				table.remove(objs,index)
			end
			objsNew[i] = nil
		end
	end

	for i=1,#objs do
		local obj = objs[i]
		if obj.updateInterval and obj.updateInterval>0 then
			obj.deltaTime = obj.deltaTime+deltaTime
			obj.updateTime = obj.updateTime+unscaledDeltaTime
			if obj.updateTime>=obj.updateInterval then
				obj:OnUpdate(obj.deltaTime,obj.updateTime)
				obj.updateTime = 0
				obj.deltaTime = 0
			end
		else
			obj:OnUpdate(deltaTime,unscaledDeltaTime)

		end
	end

	if IsEditor then
		LuaEntry:DebugCheckRestart()
	end
end

function LuaEntry:OnLateUpdate(deltaTime, unscaledDeltaTime)
	for key, form in pairs(self.lateUpdateForms) do
		form:OnLateUpdate(deltaTime, unscaledDeltaTime)
	end
end

function LuaEntry:OnApplicationPause(pause)
	for name, module in pairs(LuaEntry.modules) do
		module:OnApplicationPause(pause)
	end
	GameEntry.Event:Fire(self, ReferencePool.Acquire(typeof(PS.CommonEventArgs)):Fill(CommonEventType.ApplicationPause, pause))
end

function LuaEntry:OnApplicationQuit()
	for name, module in pairs(self.modules) do
		module:OnApplicationQuit()
	end
end

function LuaEntry:OnDestroy()
	self:Clear()
	self:UnrequireAll()
end

function LuaEntry:RegisterUpdate(obj)
	table.insert(self.updateObjs_new, {obj=obj, type=1})
end

function LuaEntry:UnregisterUpdate(obj)
	table.insert(self.updateObjs_new, {obj=obj, type=0})
end

function LuaEntry:RegisterLateUpdate(form)
	if self.lateUpdateForms[form] == nil then
		self.lateUpdateForms[form] = form
	end
end

function LuaEntry:UnregisterLateUpdate(form)
	if self.lateUpdateForms[form] then
		self.lateUpdateForms[form] = nil
	end
end

function LuaEntry:RegisterModule(name, file)
	if self[name] ~= nil then
		Log.Warning("module {0} - {1} already exist", name, file)
		return
	end
	local Module = require(file)
	local mod = Module.New()
	self[name] = mod
	self.modules[name] = mod
	mod:Init()
end

function LuaEntry:UnregisterModule(name)
	if self[name] ~= nil then
		self[name]:Destroy()
		self[name] = nil
		self.modules[name] = nil
	end
end

function LuaEntry:UnregisterAllModule()
	for name, module in pairs(self.modules) do
		self[name] = nil
		module:Destroy()
	end
	self.modules = nil
end

function LuaEntry:ReInitModules()
	for i, mod in pairs(self.modules) do
		mod:Clear()
	end
end

function LuaEntry:Clear()
	xlua.clear()
	--Lang.Clear()
	--DataTable.Clear()
	self:UnregisterAllModule()
	self.updateObjs = nil
	self.updateObjs_new = nil
	self.lateUpdateForms = nil
	self:ClearGlobal()
end

function LuaEntry:ClearGlobal()
	for key, v in pairs(_G) do
		if not self.Global[key] then
			_G[key] = nil
		end
	end
end

function LuaEntry:UnrequireAll()
	for key, v in pairs(package.loaded) do
		if not self.package[key] then
			package.loaded[key] = nil
		end
	end
end

function LuaEntry:DebugCheckRestart()
	if Input.GetKey(KeyCode.LeftControl) then
		if Input.GetKey(KeyCode.BackQuote) then
			local proc = LuaEntry.ProcedureModule.currentProcedure
			if proc.name == "Main" then
				proc:OnNotify("BackToRestart")
			else
                local currentProcedure = LuaEntry.ProcedureModule.currentProcedure;
                currentProcedure:BackToLogin()
			end		
		elseif Input.GetKey(KeyCode.Q) then
			local proc = LuaEntry.ProcedureModule.currentProcedure
			if proc.name == "Main" then
				proc:OnNotify("BackToSelRole")
			end
		end
	end	
end