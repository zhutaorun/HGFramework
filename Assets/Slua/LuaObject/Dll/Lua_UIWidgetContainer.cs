using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIWidgetContainer : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIWidgetContainer");
		createTypeMetatable(l,null, typeof(UIWidgetContainer),typeof(UnityEngine.MonoBehaviour));
	}
}
