using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIStretch : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uiCamera(IntPtr l) {
		try {
			UIStretch self=(UIStretch)checkSelf(l);
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
			UIStretch self=(UIStretch)checkSelf(l);
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
			UIStretch self=(UIStretch)checkSelf(l);
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
			UIStretch self=(UIStretch)checkSelf(l);
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
	static public int get_style(IntPtr l) {
		try {
			UIStretch self=(UIStretch)checkSelf(l);
			pushEnum(l,(int)self.style);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_style(IntPtr l) {
		try {
			UIStretch self=(UIStretch)checkSelf(l);
			UIStretch.Style v;
			checkEnum(l,2,out v);
			self.style=v;
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
			UIStretch self=(UIStretch)checkSelf(l);
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
			UIStretch self=(UIStretch)checkSelf(l);
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
	static public int get_relativeSize(IntPtr l) {
		try {
			UIStretch self=(UIStretch)checkSelf(l);
			pushValue(l,self.relativeSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_relativeSize(IntPtr l) {
		try {
			UIStretch self=(UIStretch)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.relativeSize=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_initialSize(IntPtr l) {
		try {
			UIStretch self=(UIStretch)checkSelf(l);
			pushValue(l,self.initialSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_initialSize(IntPtr l) {
		try {
			UIStretch self=(UIStretch)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.initialSize=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_borderPadding(IntPtr l) {
		try {
			UIStretch self=(UIStretch)checkSelf(l);
			pushValue(l,self.borderPadding);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_borderPadding(IntPtr l) {
		try {
			UIStretch self=(UIStretch)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.borderPadding=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIStretch");
		addMember(l,"uiCamera",get_uiCamera,set_uiCamera,true);
		addMember(l,"container",get_container,set_container,true);
		addMember(l,"style",get_style,set_style,true);
		addMember(l,"runOnlyOnce",get_runOnlyOnce,set_runOnlyOnce,true);
		addMember(l,"relativeSize",get_relativeSize,set_relativeSize,true);
		addMember(l,"initialSize",get_initialSize,set_initialSize,true);
		addMember(l,"borderPadding",get_borderPadding,set_borderPadding,true);
		createTypeMetatable(l,null, typeof(UIStretch),typeof(UnityEngine.MonoBehaviour));
	}
}
