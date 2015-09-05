using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_ConfigMgr : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Init(IntPtr l) {
		try {
			ConfigMgr self=(ConfigMgr)checkSelf(l);
			var ret=self.Init();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetConfig(IntPtr l) {
		try {
			ConfigMgr self=(ConfigMgr)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetConfig(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Instance_s(IntPtr l) {
		try {
			var ret=ConfigMgr.Instance();
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
		addMember(l,Init);
		addMember(l,GetConfig);
		addMember(l,Instance_s);
		createTypeMetatable(l,null, typeof(ConfigMgr));
	}
}
