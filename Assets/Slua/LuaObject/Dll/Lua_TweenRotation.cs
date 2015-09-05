using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_TweenRotation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			TweenRotation o;
			o=new TweenRotation();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetStartToCurrentValue(IntPtr l) {
		try {
			TweenRotation self=(TweenRotation)checkSelf(l);
			self.SetStartToCurrentValue();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetEndToCurrentValue(IntPtr l) {
		try {
			TweenRotation self=(TweenRotation)checkSelf(l);
			self.SetEndToCurrentValue();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Begin_s(IntPtr l) {
		try {
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			var ret=TweenRotation.Begin(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_from(IntPtr l) {
		try {
			TweenRotation self=(TweenRotation)checkSelf(l);
			pushValue(l,self.from);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_from(IntPtr l) {
		try {
			TweenRotation self=(TweenRotation)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.from=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_to(IntPtr l) {
		try {
			TweenRotation self=(TweenRotation)checkSelf(l);
			pushValue(l,self.to);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_to(IntPtr l) {
		try {
			TweenRotation self=(TweenRotation)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.to=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_quaternionLerp(IntPtr l) {
		try {
			TweenRotation self=(TweenRotation)checkSelf(l);
			pushValue(l,self.quaternionLerp);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_quaternionLerp(IntPtr l) {
		try {
			TweenRotation self=(TweenRotation)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.quaternionLerp=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTransform(IntPtr l) {
		try {
			TweenRotation self=(TweenRotation)checkSelf(l);
			pushValue(l,self.cachedTransform);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		try {
			TweenRotation self=(TweenRotation)checkSelf(l);
			pushValue(l,self.value);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		try {
			TweenRotation self=(TweenRotation)checkSelf(l);
			UnityEngine.Quaternion v;
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
		getTypeTable(l,"TweenRotation");
		addMember(l,SetStartToCurrentValue);
		addMember(l,SetEndToCurrentValue);
		addMember(l,Begin_s);
		addMember(l,"from",get_from,set_from,true);
		addMember(l,"to",get_to,set_to,true);
		addMember(l,"quaternionLerp",get_quaternionLerp,set_quaternionLerp,true);
		addMember(l,"cachedTransform",get_cachedTransform,null,true);
		addMember(l,"value",get_value,set_value,true);
		createTypeMetatable(l,constructor, typeof(TweenRotation),typeof(UITweener));
	}
}
