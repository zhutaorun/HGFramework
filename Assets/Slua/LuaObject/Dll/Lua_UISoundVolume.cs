using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISoundVolume : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISoundVolume");
		createTypeMetatable(l,null, typeof(UISoundVolume),typeof(UnityEngine.MonoBehaviour));
	}
}
