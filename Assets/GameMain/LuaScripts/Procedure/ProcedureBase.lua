
ProcedureBase = class("ProcedureBase")

function ProcedureBase:Create(name)
	self.name = name
end

function ProcedureBase:OnEnter(procedureOwner)
	local procedureModule = LuaEntry.ProcedureModule
	procedureModule.prevProcedure = procedureModule.currentProcedure
	procedureModule.currentProcedure = self

end

function ProcedureBase:OnLeave(procedureOwner,isShutDown)

end

function ProcedureBase:OnUpdate(procedureOwner,elapseSeconds,realElapseSeconds)

end

function ProcedureBase:OnDestroy(procedureOwner)
	
end

function ProcedureBase:ChangeState(procedureName)
	local scType = typeof(Game["Procedure"..procedureName])
	LuaEntry.ProcedureModule.nextProcedureName = procedureName
	self["C#"]:ChangeState(csType)
end