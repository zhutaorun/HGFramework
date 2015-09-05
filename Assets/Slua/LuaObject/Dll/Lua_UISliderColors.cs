using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISliderColors : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sprite(IntPtr l) {
		try {
			UISliderColors self=(UISliderColors)checkSelf(l);
			pushValue(l,self.sprite);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sprite(IntPtr l) {
		try {
			UISliderColors self=(UISliderColors)checkSelf(l);
			UISprite v;
			checkType(l,2,out v);
			self.sprite=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colors(IntPtr l) {
		try {
			UISliderColors self=(UISliderColors)checkSelf(l);
			pushValue(l,self.colors);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colors(IntPtr l) {
		try {
			UISliderColors self=(UISliderColors)checkSelf(l);
			UnityEngine.Color[] v;
			checkType(l,2,out v);
			self.colors=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISliderColors");
		addMember(l,"sprite",get_sprite,set_sprite,true);
		addMember(l,"colors",get_colors,set_colors,true);
		createTypeMetatable(l,null, typeof(UISliderColors),typeof(UnityEngine.MonoBehaviour));
	}
}
