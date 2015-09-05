using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UITooltip : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Show_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UITooltip.Show(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Hide_s(IntPtr l) {
		try {
			UITooltip.Hide();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uiCamera(IntPtr l) {
		try {
			UITooltip self=(UITooltip)checkSelf(l);
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
			UITooltip self=(UITooltip)checkSelf(l);
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
	static public int get_text(IntPtr l) {
		try {
			UITooltip self=(UITooltip)checkSelf(l);
			pushValue(l,self.text);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		try {
			UITooltip self=(UITooltip)checkSelf(l);
			UILabel v;
			checkType(l,2,out v);
			self.text=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_background(IntPtr l) {
		try {
			UITooltip self=(UITooltip)checkSelf(l);
			pushValue(l,self.background);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_background(IntPtr l) {
		try {
			UITooltip self=(UITooltip)checkSelf(l);
			UISprite v;
			checkType(l,2,out v);
			self.background=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_appearSpeed(IntPtr l) {
		try {
			UITooltip self=(UITooltip)checkSelf(l);
			pushValue(l,self.appearSpeed);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_appearSpeed(IntPtr l) {
		try {
			UITooltip self=(UITooltip)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.appearSpeed=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scalingTransitions(IntPtr l) {
		try {
			UITooltip self=(UITooltip)checkSelf(l);
			pushValue(l,self.scalingTransitions);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scalingTransitions(IntPtr l) {
		try {
			UITooltip self=(UITooltip)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.scalingTransitions=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isVisible(IntPtr l) {
		try {
			pushValue(l,UITooltip.isVisible);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UITooltip");
		addMember(l,Show_s);
		addMember(l,Hide_s);
		addMember(l,"uiCamera",get_uiCamera,set_uiCamera,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"background",get_background,set_background,true);
		addMember(l,"appearSpeed",get_appearSpeed,set_appearSpeed,true);
		addMember(l,"scalingTransitions",get_scalingTransitions,set_scalingTransitions,true);
		addMember(l,"isVisible",get_isVisible,null,false);
		createTypeMetatable(l,null, typeof(UITooltip),typeof(UnityEngine.MonoBehaviour));
	}
}
