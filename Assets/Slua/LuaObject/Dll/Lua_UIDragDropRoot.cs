using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragDropRoot : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_root(IntPtr l) {
		try {
			pushValue(l,UIDragDropRoot.root);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_root(IntPtr l) {
		try {
			UnityEngine.Transform v;
			checkType(l,2,out v);
			UIDragDropRoot.root=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragDropRoot");
		addMember(l,"root",get_root,set_root,false);
		createTypeMetatable(l,null, typeof(UIDragDropRoot),typeof(UnityEngine.MonoBehaviour));
	}
}
