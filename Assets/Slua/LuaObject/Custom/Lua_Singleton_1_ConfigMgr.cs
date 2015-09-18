using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Singleton_1_ConfigMgr : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Instance_s(IntPtr l) {
		try {
			var ret=Singleton<ConfigMgr>.Instance();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ConfigMgr");
		addMember(l,Instance_s);
		createTypeMetatable(l,null, typeof(Singleton<ConfigMgr>));
	}
}
