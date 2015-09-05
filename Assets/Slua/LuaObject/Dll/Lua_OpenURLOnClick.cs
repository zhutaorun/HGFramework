using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_OpenURLOnClick : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"OpenURLOnClick");
		createTypeMetatable(l,null, typeof(OpenURLOnClick),typeof(UnityEngine.MonoBehaviour));
	}
}
