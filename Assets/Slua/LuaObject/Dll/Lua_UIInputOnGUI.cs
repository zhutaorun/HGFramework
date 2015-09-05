using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIInputOnGUI : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIInputOnGUI");
		createTypeMetatable(l,null, typeof(UIInputOnGUI),typeof(UnityEngine.MonoBehaviour));
	}
}
