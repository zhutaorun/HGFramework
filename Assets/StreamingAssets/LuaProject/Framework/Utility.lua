--工具类
Utility = {};

--设置父子关系
--childTrans: 子节点，Transform
--parentTrans: 父节点，Transform
function Utility.SetParent(childTrans, parentTrans)
	if not childTrans then
		Logger.Error("SetParent childTrans is nil");
		return;
	end
	if not parentTrans then
		Logger.Error("SetParent parentTrans is nil");
		return;
	end
	childTrans.parent = parentTrans;
end

--设置父子关系，并归一，位移归零，旋转归零，缩放归一
--childTrans: 子节点，Transform
--parentTrans: 父节点，Transform
function Utility.SetParentNormally(childTrans, parentTrans)
	Utility.SetParent(childTrans, parentTrans);
	childTrans.localPosition = Vector3.zero;
	childTrans.localRotation = Quaternion.identity;
	childTrans.localScale = Vector3.one;
end

--简化创建LuaBehaviour并关联的接口
function Utility.CreateLuaBehaviour(gameObj, luaTable)
	if not gameObj then
		return nil;
	end
	if not luaTable then
		return nil;
	end
	
	local luaBeh = gameObj:AddComponent("LuaBehaviour");
	luaBeh.table = luaTable;
	--缓存gameObject与transform
	luaTable.gameObj = gameObj;
	luaTable.trans = gameObj.transform;
	--模拟Awake声明周期
	if luaTable.Awake then
		luaTable:Awake();
	end
	return luaTable;
end

function Utility.lua_string_split(str, split_char)
    local sub_str_tab = {};
    while (true) do
        local pos = string.find(str, split_char);
        if (not pos) then
            sub_str_tab[#sub_str_tab + 1] = str;
            break;
        end
        local sub_str = string.sub(str, 1, pos - 1);
        sub_str_tab[#sub_str_tab + 1] = sub_str;
        str = string.sub(str, pos + 1, #str);
    end

    return sub_str_tab;
end