LuaObject = class("LuaObject")

function LuaObject:Create()
	-- 注册Update
	self.isRegisterUpdate = false
	-- 注册LateUpdate
	self.isRegisterLateUpdate = false
	-- 事件订阅表
	self.subscribeEvents = {}
	-- 获取引用缓存
	self.referenceCache = {}
end

function LuaObject:StopLogic()
	self:UnregisterUpdate()
	self:UnregisterLateUpdate()
	self:UnsubscribeAllEvent()
	self:ReleaseAllReference()
end

function LuaObject:OnDestroy()
	self:StopLogic()
	self.subscribeEvents = nil
	self.referenceCache = nil
end

function LuaObject:RegisterUpdate(interval)
	if self.isRegisterUpdate then
		return
	end
	self.isRegisterUpdate = true
	self.updateInterval = interval or 0
	self.updateTime = 0
	self.deltaTime = 0
	LuaEntry:RegisterUpdate()
end

function LuaObject:UnregisterUpdate()
	if self.isRegisterUpdate then
		LuaEntry:UnregisterUpdate()
		self.isRegisterUpdate = false
	end
end

function LuaObject:RegisterLateUpdate()
	if self.isRegisterLateUpdate then
		return
	end
	LuaEntry:RegisterLateUpdate()
	self.isRegisterLateUpdate = true
end

function LuaObject:UnregisterLateUpdate()
	if self.isRegisterLateUpdate then
		LuaEntry:UnregisterLateUpdate()
		self.isRegisterLateUpdate = false
	end
end

function LuaObject:subscribeEvents(id,handler)
	if self.subscribeEvents[id] then
		Log.Warning("Event {0}({1}) already subscribed.", GameEntry.Event:GetEventType(id).FullName, id)
		return
	end

	if handler==nil then
		Log.Warning("Event handler for {0}({1}) is null.", GameEntry.Event:GetEventType(id).FullName, id)
		return
	end
	self.subscribeEvents[id] = handler
	GameEntry.Event:Subscribe(id,handler)
end

function LuaObject:UnsubscribeEvent(id)
	if self.subscribeEvents[id]==nil then
		Log.Warning("Event id {0}, name {1} not subscribed.", id, PS.EventUtility.GetEventName(id))
		return
	end

	if GameEntry.Event~=nil then
		GameEntry.Event:Unsubscribe(id,self.subscribeEvents[id])
	end
	self.subscribeEvents[id] = nil
end

function LuaObject:UnsubscribeAllEvent()
	for id, handler in pairs(self.subscribeEvents) do
		if GameEntry.Event ~= nil and GameEntry.Event:Check(id, handler) then
			GameEntry.Event:Unsubscribe(id, handler)
		end
	end
	self.subscribeEvents = {}
end

function LuaObject:ReleaseReference(reference)
	if self.referenceCache[reference]==nil then
		Log.Warning("Reference {0} not found.", reference.GetType())
	end
	ReferencePool.Release(self.referenceCache[reference], reference)
	self.referenceCache[reference] = nil
end

function LuaObject:ReleaseAllReference()
	for k,v in pairs(self.referenceCache) do
		ReferencePool.Release(self.referenceCache[k],k)
	end
	self.referenceCache = {}
end

-- 创建一个通用事件
function LuaObject:AcquireCommonEvent(type, data)
	local ref = ReferencePool.Acquire(typeof(PS.CommonEventArgs))
	ref:Fill(type, data)
	return ref
end