
ModuleBase = class("ModuleBase",LuaObject)

function ModuleBase:Create(name)
    ModuleBase.super:Create()
end

function ModuleBase:OnApplicationPause(pause)
   
end

function ModuleBase:OnApplicationQuit()

end

function ModuleBase:Destroy()
	self:StopLogic()
	self.data = nil
end

function ModuleBase:Clear()
	self:StopLogic()
	self.Init()
end

--初始化数据
function ModuleBase:InitBindData()
	self.data = {}
	self.data.data = {}
	self.data.func = {}
	setmetatable(self.data,{
		__index = function(table,key)
			return table.data[key]
		end,
		__newIndex = function(table,key,value)
			table.data[key] = value
			if table.func[key]~=nil then
				for _,callback in pairs(table.func[key]) do
					callback(table.data[key])
				end
			end
		end
		})
end

-- 绑定数据
-- @param : key 属性名
-- @param : calllback 回调
-- ======================================
function ModuleBase:BindData(key,callback)
	if self.data == nil then
		self:InitBindData()
	end
	self.data.func[key] = self.data.func[key] or {}
	table.insert(self.data.func[key], callback)
end

-- 解绑数据
-- @param : key 属性名
-- @param : calllback 回调
-- ======================================
function ModuleBase:UnbindData(key,callback)
	if self.data.func ~= nil and self.data.func[key] ~= nil then
		for i, call in ipairs(self.data.func[key]) do
			if call == callback then
				table.remove(self.data.func[key], i)
				break
			end
		end
	end
end
