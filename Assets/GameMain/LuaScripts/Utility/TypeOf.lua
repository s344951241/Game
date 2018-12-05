local typeCache = {}

function typeof(systemType)
	if typeCache[systemType]~=nil then
		return typeCache[systemType]
	end
	typeCache[systemType] = systemType.UnderlyingSystemType
	return typeCache[systemType]
end