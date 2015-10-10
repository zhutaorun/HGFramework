using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Tizen_Window : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Tizen.Window o;
			o=new UnityEngine.Tizen.Window();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_windowHandle(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Tizen.Window.windowHandle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Tizen.Window");
		addMember(l,"windowHandle",get_windowHandle,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Tizen.Window));
	}
}
