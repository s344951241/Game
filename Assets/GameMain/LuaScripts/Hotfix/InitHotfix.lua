local hotfixTable = {}

local hotfix = xlua.hotfix

xlua.hotfix = function(class,method,func)
	hotfix(class,method,func)
	hotfixTable[class] = hotfixTable[class] or {}
	if type(method)=="table" then
		for _,m in pairs(method) do
			if type(m)=="function" then
				table.insert(hotfixTable[class],m)
			end
		end
	elseif type(method)=="string" then
		table.insert(hotfixTable[class],method)
	end
end


xlua.clear = function()
	for class,methods in pairs(hotfixTable) do
		for _,method in ipairs(methods) do
			hotfix(class,method,nil)
		end
	end
end