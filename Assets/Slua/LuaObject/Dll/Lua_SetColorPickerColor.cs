using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_SetColorPickerColor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetToCurrent(IntPtr l) {
		try {
			SetColorPickerColor self=(SetColorPickerColor)checkSelf(l);
			self.SetToCurrent();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"SetColorPickerColor");
		addMember(l,SetToCurrent);
		createTypeMetatable(l,null, typeof(SetColorPickerColor),typeof(UnityEngine.MonoBehaviour));
	}
}
