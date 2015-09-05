using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragResize : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
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
			UIDragResize self=(UIDragResize)checkSelf(l);
			UIWidget v;
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
	static public int get_pivot(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			pushEnum(l,(int)self.pivot);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivot(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			UIWidget.Pivot v;
			checkEnum(l,2,out v);
			self.pivot=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			pushValue(l,self.minWidth);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minWidth(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.minWidth=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			pushValue(l,self.minHeight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minHeight(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.minHeight=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxWidth(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			pushValue(l,self.maxWidth);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxWidth(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.maxWidth=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxHeight(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			pushValue(l,self.maxHeight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxHeight(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.maxHeight=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateAnchors(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			pushValue(l,self.updateAnchors);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateAnchors(IntPtr l) {
		try {
			UIDragResize self=(UIDragResize)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.updateAnchors=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragResize");
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"pivot",get_pivot,set_pivot,true);
		addMember(l,"minWidth",get_minWidth,set_minWidth,true);
		addMember(l,"minHeight",get_minHeight,set_minHeight,true);
		addMember(l,"maxWidth",get_maxWidth,set_maxWidth,true);
		addMember(l,"maxHeight",get_maxHeight,set_maxHeight,true);
		addMember(l,"updateAnchors",get_updateAnchors,set_updateAnchors,true);
		createTypeMetatable(l,null, typeof(UIDragResize),typeof(UnityEngine.MonoBehaviour));
	}
}
