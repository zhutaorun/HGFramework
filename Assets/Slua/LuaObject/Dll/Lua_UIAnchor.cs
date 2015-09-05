using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIAnchor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uiCamera(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			pushValue(l,self.uiCamera);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uiCamera(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			UnityEngine.Camera v;
			checkType(l,2,out v);
			self.uiCamera=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_container(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			pushValue(l,self.container);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_container(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			UnityEngine.GameObject v;
			checkType(l,2,out v);
			self.container=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_side(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			pushEnum(l,(int)self.side);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_side(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			UIAnchor.Side v;
			checkEnum(l,2,out v);
			self.side=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_runOnlyOnce(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			pushValue(l,self.runOnlyOnce);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_runOnlyOnce(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.runOnlyOnce=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relativeOffset(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			pushValue(l,self.relativeOffset);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_relativeOffset(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.relativeOffset=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelOffset(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			pushValue(l,self.pixelOffset);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelOffset(IntPtr l) {
		try {
			UIAnchor self=(UIAnchor)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.pixelOffset=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIAnchor");
		addMember(l,"uiCamera",get_uiCamera,set_uiCamera,true);
		addMember(l,"container",get_container,set_container,true);
		addMember(l,"side",get_side,set_side,true);
		addMember(l,"runOnlyOnce",get_runOnlyOnce,set_runOnlyOnce,true);
		addMember(l,"relativeOffset",get_relativeOffset,set_relativeOffset,true);
		addMember(l,"pixelOffset",get_pixelOffset,set_pixelOffset,true);
		createTypeMetatable(l,null, typeof(UIAnchor),typeof(UnityEngine.MonoBehaviour));
	}
}
