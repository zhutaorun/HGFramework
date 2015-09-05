using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIStorageSlot : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UIStorageSlot o;
			o=new UIStorageSlot();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_storage(IntPtr l) {
		try {
			UIStorageSlot self=(UIStorageSlot)checkSelf(l);
			pushValue(l,self.storage);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_storage(IntPtr l) {
		try {
			UIStorageSlot self=(UIStorageSlot)checkSelf(l);
			UIItemStorage v;
			checkType(l,2,out v);
			self.storage=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_slot(IntPtr l) {
		try {
			UIStorageSlot self=(UIStorageSlot)checkSelf(l);
			pushValue(l,self.slot);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_slot(IntPtr l) {
		try {
			UIStorageSlot self=(UIStorageSlot)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.slot=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIStorageSlot");
		addMember(l,"storage",get_storage,set_storage,true);
		addMember(l,"slot",get_slot,set_slot,true);
		createTypeMetatable(l,constructor, typeof(UIStorageSlot),typeof(UIItemSlot));
	}
}
