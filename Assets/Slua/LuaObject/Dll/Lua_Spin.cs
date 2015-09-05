using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Spin : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ApplyDelta(IntPtr l) {
		try {
			Spin self=(Spin)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.ApplyDelta(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationsPerSecond(IntPtr l) {
		try {
			Spin self=(Spin)checkSelf(l);
			pushValue(l,self.rotationsPerSecond);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotationsPerSecond(IntPtr l) {
		try {
			Spin self=(Spin)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.rotationsPerSecond=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreTimeScale(IntPtr l) {
		try {
			Spin self=(Spin)checkSelf(l);
			pushValue(l,self.ignoreTimeScale);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreTimeScale(IntPtr l) {
		try {
			Spin self=(Spin)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.ignoreTimeScale=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Spin");
		addMember(l,ApplyDelta);
		addMember(l,"rotationsPerSecond",get_rotationsPerSecond,set_rotationsPerSecond,true);
		addMember(l,"ignoreTimeScale",get_ignoreTimeScale,set_ignoreTimeScale,true);
		createTypeMetatable(l,null, typeof(Spin),typeof(UnityEngine.MonoBehaviour));
	}
}
