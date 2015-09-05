using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_WindowAutoYaw : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateOrder(IntPtr l) {
		try {
			WindowAutoYaw self=(WindowAutoYaw)checkSelf(l);
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
			WindowAutoYaw self=(WindowAutoYaw)checkSelf(l);
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
	static public int get_uiCamera(IntPtr l) {
		try {
			WindowAutoYaw self=(WindowAutoYaw)checkSelf(l);
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
			WindowAutoYaw self=(WindowAutoYaw)checkSelf(l);
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
	static public int get_yawAmount(IntPtr l) {
		try {
			WindowAutoYaw self=(WindowAutoYaw)checkSelf(l);
			pushValue(l,self.yawAmount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yawAmount(IntPtr l) {
		try {
			WindowAutoYaw self=(WindowAutoYaw)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.yawAmount=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"WindowAutoYaw");
		addMember(l,"updateOrder",get_updateOrder,set_updateOrder,true);
		addMember(l,"uiCamera",get_uiCamera,set_uiCamera,true);
		addMember(l,"yawAmount",get_yawAmount,set_yawAmount,true);
		createTypeMetatable(l,null, typeof(WindowAutoYaw),typeof(UnityEngine.MonoBehaviour));
	}
}
