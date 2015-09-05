using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LoadLevelOnClick : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_levelName(IntPtr l) {
		try {
			LoadLevelOnClick self=(LoadLevelOnClick)checkSelf(l);
			pushValue(l,self.levelName);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_levelName(IntPtr l) {
		try {
			LoadLevelOnClick self=(LoadLevelOnClick)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.levelName=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LoadLevelOnClick");
		addMember(l,"levelName",get_levelName,set_levelName,true);
		createTypeMetatable(l,null, typeof(LoadLevelOnClick),typeof(UnityEngine.MonoBehaviour));
	}
}
