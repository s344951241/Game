---lua 入口

Main= {}

local require = require
require "Driver.Functions"
require "Net.protobuf"
require "Driver.CSharpCall"
require "Driver.LuaStart"
require "Net.LuaNet"


local CS = CS
local EventManager = CS.EventManager
local EventConst = CS.EventConst
local SimpleEventArgs = CS.SimpleEventArgs
local LuaProtoTest = CS.LuaProtoTest

function Main:Start()
	print("------------lua启动ing")
	local test = require "Com.ModuleOne"
	test:ShowName()
	LuaStart:Start()
	LuaStart:TestMethod("11111")
    xlua.hotfix(CS.HotfixTool,'ShowString',function(self)
	 		print("this is lua string")
		end)

	CS.HotfixTool:ShowString()
	EventManager.Instance:addEvent(EventConst.EVENT_TEST2,self.EventCall)
	EventManager.Instance:invokeEvent(EventConst.EVENT_TEST,SimpleEventArgs("11111"),self)
	
	local profiler = require "Resources.perf.profiler"
	profiler.start()
	print(profiler.report())
	LuaNet:Init()
	print(profiler.report())
	profiler.stop()
	
	--[[local test = {
		id = 123456,
		name = "vv"
	}
	local code = pb.encode("ProtoBuf.TestProto",test)
	LuaProtoTest.Instance:getLuaCode(code)
	local code2 = pb.decode("ProtoBuf.TestProto",code)
	print(code2.name)--]]
end

function Main.EventCall(sender,e)
	print(sender,"触发了lua定义的事件",e.Name)
end	

Main:Start()

return Main