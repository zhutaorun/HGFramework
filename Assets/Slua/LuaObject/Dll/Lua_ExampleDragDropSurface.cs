using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_ExampleDragDropSurface : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotatePlacedObject(IntPtr l) {
		try {
			ExampleDragDropSurface self=(ExampleDragDropSurface)checkSelf(l);
			pushValue(l,self.rotatePlacedObject);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotatePlacedObject(IntPtr l) {
		try {
			ExampleDragDropSurface self=(ExampleDragDropSurface)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.rotatePlacedObject=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ExampleDragDropSurface");
		addMember(l,"rotatePlacedObject",get_rotatePlacedObject,set_rotatePlacedObject,true);
		createTypeMetatable(l,null, typeof(ExampleDragDropSurface),typeof(UnityEngine.MonoBehaviour));
	}
}
