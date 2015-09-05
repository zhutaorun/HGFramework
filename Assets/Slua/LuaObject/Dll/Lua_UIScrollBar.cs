using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIScrollBar : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UIScrollBar o;
			o=new UIScrollBar();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ForceUpdate(IntPtr l) {
		try {
			UIScrollBar self=(UIScrollBar)checkSelf(l);
			self.ForceUpdate();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_barSize(IntPtr l) {
		try {
			UIScrollBar self=(UIScrollBar)checkSelf(l);
			pushValue(l,self.barSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_barSize(IntPtr l) {
		try {
			UIScrollBar self=(UIScrollBar)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.barSize=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIScrollBar");
		addMember(l,ForceUpdate);
		addMember(l,"barSize",get_barSize,set_barSize,true);
		createTypeMetatable(l,constructor, typeof(UIScrollBar),typeof(UISlider));
	}
}
