using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISlider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UISlider o;
			o=new UISlider();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPan(IntPtr l) {
		try {
			UISlider self=(UISlider)checkSelf(l);
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
	static public int get_isColliderEnabled(IntPtr l) {
		try {
			UISlider self=(UISlider)checkSelf(l);
			pushValue(l,self.isColliderEnabled);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISlider");
		addMember(l,OnPan);
		addMember(l,"isColliderEnabled",get_isColliderEnabled,null,true);
		createTypeMetatable(l,constructor, typeof(UISlider),typeof(UIProgressBar));
	}
}
