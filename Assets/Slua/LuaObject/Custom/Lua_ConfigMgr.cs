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
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetConfig(IntPtr l) {
		try {
			ConfigMgr self=(ConfigMgr)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetConfig(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ConfigMgr");
		addMember(l,Init);
		addMember(l,GetConfig);
		createTypeMetatable(l,null, typeof(ConfigMgr),typeof(Singleton<ConfigMgr>));
	}
}
