using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_AnimatedWidget : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		try {
			AnimatedWidget self=(AnimatedWidget)checkSelf(l);
			pushValue(l,self.width);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		try {
			AnimatedWidget self=(AnimatedWidget)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.width=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		try {
			AnimatedWidget self=(AnimatedWidget)checkSelf(l);
			pushValue(l,self.height);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		try {
			AnimatedWidget self=(AnimatedWidget)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.height=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"AnimatedWidget");
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		createTypeMetatable(l,null, typeof(AnimatedWidget),typeof(UnityEngine.MonoBehaviour));
	}
}
