using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIKeyBinding : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsBound_s(IntPtr l) {
		try {
			UnityEngine.KeyCode a1;
			checkEnum(l,1,out a1);
			var ret=UIKeyBinding.IsBound(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyCode(IntPtr l) {
		try {
			UIKeyBinding self=(UIKeyBinding)checkSelf(l);
			pushEnum(l,(int)self.keyCode);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyCode(IntPtr l) {
		try {
			UIKeyBinding self=(UIKeyBinding)checkSelf(l);
			UnityEngine.KeyCode v;
			checkEnum(l,2,out v);
			self.keyCode=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modifier(IntPtr l) {
		try {
			UIKeyBinding self=(UIKeyBinding)checkSelf(l);
			pushEnum(l,(int)self.modifier);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_modifier(IntPtr l) {
		try {
			UIKeyBinding self=(UIKeyBinding)checkSelf(l);
			UIKeyBinding.Modifier v;
			checkEnum(l,2,out v);
			self.modifier=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_action(IntPtr l) {
		try {
			UIKeyBinding self=(UIKeyBinding)checkSelf(l);
			pushEnum(l,(int)self.action);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_action(IntPtr l) {
		try {
			UIKeyBinding self=(UIKeyBinding)checkSelf(l);
			UIKeyBinding.Action v;
			checkEnum(l,2,out v);
			self.action=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIKeyBinding");
		addMember(l,IsBound_s);
		addMember(l,"keyCode",get_keyCode,set_keyCode,true);
		addMember(l,"modifier",get_modifier,set_modifier,true);
		addMember(l,"action",get_action,set_action,true);
		createTypeMetatable(l,null, typeof(UIKeyBinding),typeof(UnityEngine.MonoBehaviour));
	}
}
