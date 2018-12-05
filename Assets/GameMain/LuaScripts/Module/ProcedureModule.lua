
local ProcedureModule = class("ProcedureModule",ModuleBase)

function ProcedureModule:Init()
	if not self.initialized then
		self.currentProcedure = nil     -- 当前流程
        self.prevProcedure = nil        -- 上个流程
        self.nextProcedureName = nil    -- 下个流程名字
	end
	self.initialized = true
end

function ProcedureModule:Destroy()
	Module:Destroy()
end

return ProcedureModule