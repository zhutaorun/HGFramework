using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Assertions_AssertionException : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Assertions.AssertionException o;
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			o=new UnityEngine.Assertions.AssertionException(a1,a2);
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Message(IntPtr l) {
		try {
			UnityEngine.Assertions.AssertionException self=(UnityEngine.Assertions.AssertionException)checkSelf(l);
			pushValue(l,self.Message);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Assertions.AssertionException");
		addMember(l,"Message",get_Message,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Assertions.AssertionException),typeof(System.Exception));
	}
}
