using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Singleton_1_ResMgr : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Instance_s(IntPtr l) {
		try {
			var ret=Singleton<ResMgr>.Instance();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ResMgr");
		addMember(l,Instance_s);
		createTypeMetatable(l,null, typeof(Singleton<ResMgr>));
	}
}
