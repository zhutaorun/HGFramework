using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UILocalize : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_key(IntPtr l) {
		try {
			UILocalize self=(UILocalize)checkSelf(l);
			pushValue(l,self.key);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_key(IntPtr l) {
		try {
			UILocalize self=(UILocalize)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.key=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		try {
			UILocalize self=(UILocalize)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.value=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UILocalize");
		addMember(l,"key",get_key,set_key,true);
		addMember(l,"value",null,set_value,true);
		createTypeMetatable(l,null, typeof(UILocalize),typeof(UnityEngine.MonoBehaviour));
	}
}
