require "LuaEntry"

function OnStart()
	LuaEntry:OnStart()
end

function OnUpdate(deltaTime, unscaledDeltaTime)
	LuaEntry:OnUpdate(deltaTime, unscaledDeltaTime)
end

function OnLateUpdate(deltaTime, unscaledDeltaTime)
	LuaEntry:OnLateUpdate(deltaTime, unscaledDeltaTime)
end

function OnApplicationPause(pause)
	LuaEntry:OnApplicationPause(pause)
end

function OnApplicationQuit()
	LuaEntry:OnApplicationQuit()
end

function OnDestroy()
	LuaEntry:OnDestroy()
end