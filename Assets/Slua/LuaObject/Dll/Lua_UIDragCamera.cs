using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragCamera : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_draggableCamera(IntPtr l) {
		try {
			UIDragCamera self=(UIDragCamera)checkSelf(l);
			pushValue(l,self.draggableCamera);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_draggableCamera(IntPtr l) {
		try {
			UIDragCamera self=(UIDragCamera)checkSelf(l);
			UIDraggableCamera v;
			checkType(l,2,out v);
			self.draggableCamera=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragCamera");
		addMember(l,"draggableCamera",get_draggableCamera,set_draggableCamera,true);
		createTypeMetatable(l,null, typeof(UIDragCamera),typeof(UnityEngine.MonoBehaviour));
	}
}
