using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_SceneMgr : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EnterScene(IntPtr l) {
		try {
			SceneMgr self=(SceneMgr)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			SceneMgr.LoadSceneDoneCallback a2;
			LuaDelegation.checkDelegate(l,3,out a2);
			System.String a3;
			checkType(l,4,out a3);
			System.String[] a4;
			checkType(l,5,out a4);
			SceneMgr.LoadSceneDoneCallback a5;
			LuaDelegation.checkDelegate(l,6,out a5);
			SceneMgr.LoadSceneUpdateProgressCallback a6;
			LuaDelegation.checkDelegate(l,7,out a6);
			self.EnterScene(a1,a2,a3,a4,a5,a6);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetResObj(IntPtr l) {
		try {
			SceneMgr self=(SceneMgr)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetResObj(a1);
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
			var ret=SceneMgr.Instance();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"SceneMgr");
		addMember(l,EnterScene);
		addMember(l,GetResObj);
		addMember(l,Instance_s);
		createTypeMetatable(l,null, typeof(SceneMgr));
	}
}
