using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_ExampleDragDropItem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			ExampleDragDropItem o;
			o=new ExampleDragDropItem();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_prefab(IntPtr l) {
		try {
			ExampleDragDropItem self=(ExampleDragDropItem)checkSelf(l);
			pushValue(l,self.prefab);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_prefab(IntPtr l) {
		try {
			ExampleDragDropItem self=(ExampleDragDropItem)checkSelf(l);
			UnityEngine.GameObject v;
			checkType(l,2,out v);
			self.prefab=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ExampleDragDropItem");
		addMember(l,"prefab",get_prefab,set_prefab,true);
		createTypeMetatable(l,constructor, typeof(ExampleDragDropItem),typeof(UIDragDropItem));
	}
}
