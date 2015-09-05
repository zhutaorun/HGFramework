using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_WindowDragTilt : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateOrder(IntPtr l) {
		try {
			WindowDragTilt self=(WindowDragTilt)checkSelf(l);
			pushValue(l,self.updateOrder);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateOrder(IntPtr l) {
		try {
			WindowDragTilt self=(WindowDragTilt)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.updateOrder=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_degrees(IntPtr l) {
		try {
			WindowDragTilt self=(WindowDragTilt)checkSelf(l);
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
			WindowDragTilt self=(WindowDragTilt)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.degrees=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"WindowDragTilt");
		addMember(l,"updateOrder",get_updateOrder,set_updateOrder,true);
		addMember(l,"degrees",get_degrees,set_degrees,true);
		createTypeMetatable(l,null, typeof(WindowDragTilt),typeof(UnityEngine.MonoBehaviour));
	}
}
