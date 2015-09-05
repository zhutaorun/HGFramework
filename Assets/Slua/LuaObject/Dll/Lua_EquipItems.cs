using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_EquipItems : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_itemIDs(IntPtr l) {
		try {
			EquipItems self=(EquipItems)checkSelf(l);
			pushValue(l,self.itemIDs);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_itemIDs(IntPtr l) {
		try {
			EquipItems self=(EquipItems)checkSelf(l);
			System.Int32[] v;
			checkType(l,2,out v);
			self.itemIDs=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"EquipItems");
		addMember(l,"itemIDs",get_itemIDs,set_itemIDs,true);
		createTypeMetatable(l,null, typeof(EquipItems),typeof(UnityEngine.MonoBehaviour));
	}
}
