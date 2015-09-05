using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_PanWithMouse : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_degrees(IntPtr l) {
		try {
			PanWithMouse self=(PanWithMouse)checkSelf(l);
			pushValue(l,self.degrees);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_degrees(IntPtr l) {
		try {
			PanWithMouse self=(PanWithMouse)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.degrees=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_range(IntPtr l) {
		try {
			PanWithMouse self=(PanWithMouse)checkSelf(l);
			pushValue(l,self.range);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_range(IntPtr l) {
		try {
			PanWithMouse self=(PanWithMouse)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.range=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"PanWithMouse");
		addMember(l,"degrees",get_degrees,set_degrees,true);
		addMember(l,"range",get_range,set_range,true);
		createTypeMetatable(l,null, typeof(PanWithMouse),typeof(UnityEngine.MonoBehaviour));
	}
}
