using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LanguageSelection : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Refresh(IntPtr l) {
		try {
			LanguageSelection self=(LanguageSelection)checkSelf(l);
			self.Refresh();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LanguageSelection");
		addMember(l,Refresh);
		createTypeMetatable(l,null, typeof(LanguageSelection),typeof(UnityEngine.MonoBehaviour));
	}
}
