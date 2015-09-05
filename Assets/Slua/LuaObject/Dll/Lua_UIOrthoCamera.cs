using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIOrthoCamera : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIOrthoCamera");
		createTypeMetatable(l,null, typeof(UIOrthoCamera),typeof(UnityEngine.MonoBehaviour));
	}
}
