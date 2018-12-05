

local ProcedureMain = class("ProcedureMain",ProcedureBase)

function ProcedureMain:Create()
	ProcedureBase:Create("Main")
end

function ProcedureMain:OnEnter(procedureOwner)
	ProcedureBase:OnEnter(procedureOwner)
	self.procedureOwner = procedureOwner
	print("LuaMainEnter")
end
function ProcedureMain:OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds)
	-- body
end
function ProcedureMain:OnNotify(param0,param1)

end

function ProcedureMain:OnLeave(procedureOwner, isShutdown)
	ProcedureBase:OnLeave(procedureOwner, isShutdown)
end

function ProcedureMain:OnDestroy()
	-- body
end
return ProcedureMain.New()