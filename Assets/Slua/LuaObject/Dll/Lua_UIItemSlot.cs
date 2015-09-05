using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIItemSlot : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_icon(IntPtr l) {
		try {
			UIItemSlot self=(UIItemSlot)checkSelf(l);
			pushValue(l,self.icon);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_icon(IntPtr l) {
		try {
			UIItemSlot self=(UIItemSlot)checkSelf(l);
			UISprite v;
			checkType(l,2,out v);
			self.icon=v;
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
			UIItemSlot self=(UIItemSlot)checkSelf(l);
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
			UIItemSlot self=(UIItemSlot)checkSelf(l);
			UIWidget v;
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
	static public int get_label(IntPtr l) {
		try {
			UIItemSlot self=(UIItemSlot)checkSelf(l);
			pushValue(l,self.label);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_label(IntPtr l) {
		try {
			UIItemSlot self=(UIItemSlot)checkSelf(l);
			UILabel v;
			checkType(l,2,out v);
			self.label=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_grabSound(IntPtr l) {
		try {
			UIItemSlot self=(UIItemSlot)checkSelf(l);
			pushValue(l,self.grabSound);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_grabSound(IntPtr l) {
		try {
			UIItemSlot self=(UIItemSlot)checkSelf(l);
			UnityEngine.AudioClip v;
			checkType(l,2,out v);
			self.grabSound=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_placeSound(IntPtr l) {
		try {
			UIItemSlot self=(UIItemSlot)checkSelf(l);
			pushValue(l,self.placeSound);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_placeSound(IntPtr l) {
		try {
			UIItemSlot self=(UIItemSlot)checkSelf(l);
			UnityEngine.AudioClip v;
			checkType(l,2,out v);
			self.placeSound=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_errorSound(IntPtr l) {
		try {
			UIItemSlot self=(UIItemSlot)checkSelf(l);
			pushValue(l,self.errorSound);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_errorSound(IntPtr l) {
		try {
			UIItemSlot self=(UIItemSlot)checkSelf(l);
			UnityEngine.AudioClip v;
			checkType(l,2,out v);
			self.errorSound=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIItemSlot");
		addMember(l,"icon",get_icon,set_icon,true);
		addMember(l,"background",get_background,set_background,true);
		addMember(l,"label",get_label,set_label,true);
		addMember(l,"grabSound",get_grabSound,set_grabSound,true);
		addMember(l,"placeSound",get_placeSound,set_placeSound,true);
		addMember(l,"errorSound",get_errorSound,set_errorSound,true);
		createTypeMetatable(l,null, typeof(UIItemSlot),typeof(UnityEngine.MonoBehaviour));
	}
}
