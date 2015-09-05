using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_PlayIdleAnimations : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"PlayIdleAnimations");
		createTypeMetatable(l,null, typeof(PlayIdleAnimations),typeof(UnityEngine.MonoBehaviour));
	}
}
