
local ModuleOne = class("ModuleOne",ModuleBase)

function ModuleOne:Init()
   	print("ModuleOneInit")
   	self:SubscribeEvent(Game.LuaEventArgs.EventId,handler(self,self.OnLuaEvent))
end

function ModuleOne:OnLuaEvent(sender,e)
	Log.Info(e.EventType)
	if e.EventType=="Main" then
		Log.Info(e.IntArgs[0])
		Log.Info(e.IntArgs[1])
	end
end
return ModuleOne