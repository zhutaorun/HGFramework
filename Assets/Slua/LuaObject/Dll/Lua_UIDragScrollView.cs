using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragScrollView : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPan(IntPtr l) {
		try {
			UIDragScrollView self=(UIDragScrollView)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			self.OnPan(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollView(IntPtr l) {
		try {
			UIDragScrollView self=(UIDragScrollView)checkSelf(l);
			pushValue(l,self.scrollView);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollView(IntPtr l) {
		try {
			UIDragScrollView self=(UIDragScrollView)checkSelf(l);
			UIScrollView v;
			checkType(l,2,out v);
			self.scrollView=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragScrollView");
		addMember(l,OnPan);
		addMember(l,"scrollView",get_scrollView,set_scrollView,true);
		createTypeMetatable(l,null, typeof(UIDragScrollView),typeof(UnityEngine.MonoBehaviour));
	}
}
