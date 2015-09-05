using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_VR_InputTracking : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.VR.InputTracking o;
			o=new UnityEngine.VR.InputTracking();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLocalPosition_s(IntPtr l) {
		try {
			UnityEngine.VR.VRNode a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.VR.InputTracking.GetLocalPosition(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLocalRotation_s(IntPtr l) {
		try {
			UnityEngine.VR.VRNode a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.VR.InputTracking.GetLocalRotation(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Recenter_s(IntPtr l) {
		try {
			UnityEngine.VR.InputTracking.Recenter();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.VR.InputTracking");
		addMember(l,GetLocalPosition_s);
		addMember(l,GetLocalRotation_s);
		addMember(l,Recenter_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.VR.InputTracking));
	}
}
