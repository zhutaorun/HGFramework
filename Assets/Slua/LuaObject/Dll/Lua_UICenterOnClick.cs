using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UICenterOnClick : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UICenterOnClick");
		createTypeMetatable(l,null, typeof(UICenterOnClick),typeof(UnityEngine.MonoBehaviour));
	}
}
