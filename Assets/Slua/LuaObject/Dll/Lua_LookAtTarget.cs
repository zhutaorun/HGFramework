using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LookAtTarget : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_level(IntPtr l) {
		try {
			LookAtTarget self=(LookAtTarget)checkSelf(l);
			pushValue(l,self.level);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_level(IntPtr l) {
		try {
			LookAtTarget self=(LookAtTarget)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.level=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		try {
			LookAtTarget self=(LookAtTarget)checkSelf(l);
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
			LookAtTarget self=(LookAtTarget)checkSelf(l);
			UnityEngine.Transform v;
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
	static public int get_speed(IntPtr l) {
		try {
			LookAtTarget self=(LookAtTarget)checkSelf(l);
			pushValue(l,self.speed);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		try {
			LookAtTarget self=(LookAtTarget)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.speed=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LookAtTarget");
		addMember(l,"level",get_level,set_level,true);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"speed",get_speed,set_speed,true);
		createTypeMetatable(l,null, typeof(LookAtTarget),typeof(UnityEngine.MonoBehaviour));
	}
}
