using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIShowControlScheme : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		try {
			UIShowControlScheme self=(UIShowControlScheme)checkSelf(l);
			pushValue(l,self.target);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		try {
			UIShowControlScheme self=(UIShowControlScheme)checkSelf(l);
			UnityEngine.GameObject v;
			checkType(l,2,out v);
			self.target=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mouse(IntPtr l) {
		try {
			UIShowControlScheme self=(UIShowControlScheme)checkSelf(l);
			pushValue(l,self.mouse);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mouse(IntPtr l) {
		try {
			UIShowControlScheme self=(UIShowControlScheme)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.mouse=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touch(IntPtr l) {
		try {
			UIShowControlScheme self=(UIShowControlScheme)checkSelf(l);
			pushValue(l,self.touch);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_touch(IntPtr l) {
		try {
			UIShowControlScheme self=(UIShowControlScheme)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.touch=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_controller(IntPtr l) {
		try {
			UIShowControlScheme self=(UIShowControlScheme)checkSelf(l);
			pushValue(l,self.controller);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_controller(IntPtr l) {
		try {
			UIShowControlScheme self=(UIShowControlScheme)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.controller=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIShowControlScheme");
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"mouse",get_mouse,set_mouse,true);
		addMember(l,"touch",get_touch,set_touch,true);
		addMember(l,"controller",get_controller,set_controller,true);
		createTypeMetatable(l,null, typeof(UIShowControlScheme),typeof(UnityEngine.MonoBehaviour));
	}
}
