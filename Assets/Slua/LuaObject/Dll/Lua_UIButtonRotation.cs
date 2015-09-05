using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIButtonRotation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tweenTarget(IntPtr l) {
		try {
			UIButtonRotation self=(UIButtonRotation)checkSelf(l);
			pushValue(l,self.tweenTarget);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tweenTarget(IntPtr l) {
		try {
			UIButtonRotation self=(UIButtonRotation)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.tweenTarget=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hover(IntPtr l) {
		try {
			UIButtonRotation self=(UIButtonRotation)checkSelf(l);
			pushValue(l,self.hover);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hover(IntPtr l) {
		try {
			UIButtonRotation self=(UIButtonRotation)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.hover=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressed(IntPtr l) {
		try {
			UIButtonRotation self=(UIButtonRotation)checkSelf(l);
			pushValue(l,self.pressed);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressed(IntPtr l) {
		try {
			UIButtonRotation self=(UIButtonRotation)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.pressed=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_duration(IntPtr l) {
		try {
			UIButtonRotation self=(UIButtonRotation)checkSelf(l);
			pushValue(l,self.duration);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_duration(IntPtr l) {
		try {
			UIButtonRotation self=(UIButtonRotation)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.duration=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIButtonRotation");
		addMember(l,"tweenTarget",get_tweenTarget,set_tweenTarget,true);
		addMember(l,"hover",get_hover,set_hover,true);
		addMember(l,"pressed",get_pressed,set_pressed,true);
		addMember(l,"duration",get_duration,set_duration,true);
		createTypeMetatable(l,null, typeof(UIButtonRotation),typeof(UnityEngine.MonoBehaviour));
	}
}
