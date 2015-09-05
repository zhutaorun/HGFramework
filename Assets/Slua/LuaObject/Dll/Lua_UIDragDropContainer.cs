using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragDropContainer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reparentTarget(IntPtr l) {
		try {
			UIDragDropContainer self=(UIDragDropContainer)checkSelf(l);
			pushValue(l,self.reparentTarget);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reparentTarget(IntPtr l) {
		try {
			UIDragDropContainer self=(UIDragDropContainer)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.reparentTarget=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragDropContainer");
		addMember(l,"reparentTarget",get_reparentTarget,set_reparentTarget,true);
		createTypeMetatable(l,null, typeof(UIDragDropContainer),typeof(UnityEngine.MonoBehaviour));
	}
}
