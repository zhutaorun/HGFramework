using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_EquipRandomItem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_equipment(IntPtr l) {
		try {
			EquipRandomItem self=(EquipRandomItem)checkSelf(l);
			pushValue(l,self.equipment);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_equipment(IntPtr l) {
		try {
			EquipRandomItem self=(EquipRandomItem)checkSelf(l);
			InvEquipment v;
			checkType(l,2,out v);
			self.equipment=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"EquipRandomItem");
		addMember(l,"equipment",get_equipment,set_equipment,true);
		createTypeMetatable(l,null, typeof(EquipRandomItem),typeof(UnityEngine.MonoBehaviour));
	}
}
