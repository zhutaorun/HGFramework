using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragDropItem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StartDragging(IntPtr l) {
		try {
			UIDragDropItem self=(UIDragDropItem)checkSelf(l);
			self.StartDragging();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopDragging(IntPtr l) {
		try {
			UIDragDropItem self=(UIDragDropItem)checkSelf(l);
			UnityEngine.GameObject a1;
			checkType(l,2,out a1);
			self.StopDragging(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_restriction(IntPtr l) {
		try {
			UIDragDropItem self=(UIDragDropItem)checkSelf(l);
			pushEnum(l,(int)self.restriction);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_restriction(IntPtr l) {
		try {
			UIDragDropItem self=(UIDragDropItem)checkSelf(l);
			UIDragDropItem.Restriction v;
			checkEnum(l,2,out v);
			self.restriction=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cloneOnDrag(IntPtr l) {
		try {
			UIDragDropItem self=(UIDragDropItem)checkSelf(l);
			pushValue(l,self.cloneOnDrag);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cloneOnDrag(IntPtr l) {
		try {
			UIDragDropItem self=(UIDragDropItem)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.cloneOnDrag=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressAndHoldDelay(IntPtr l) {
		try {
			UIDragDropItem self=(UIDragDropItem)checkSelf(l);
			pushValue(l,self.pressAndHoldDelay);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressAndHoldDelay(IntPtr l) {
		try {
			UIDragDropItem self=(UIDragDropItem)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.pressAndHoldDelay=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_interactable(IntPtr l) {
		try {
			UIDragDropItem self=(UIDragDropItem)checkSelf(l);
			pushValue(l,self.interactable);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_interactable(IntPtr l) {
		try {
			UIDragDropItem self=(UIDragDropItem)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.interactable=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_draggedItems(IntPtr l) {
		try {
			pushValue(l,UIDragDropItem.draggedItems);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_draggedItems(IntPtr l) {
		try {
			System.Collections.Generic.List<UIDragDropItem> v;
			checkType(l,2,out v);
			UIDragDropItem.draggedItems=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragDropItem");
		addMember(l,StartDragging);
		addMember(l,StopDragging);
		addMember(l,"restriction",get_restriction,set_restriction,true);
		addMember(l,"cloneOnDrag",get_cloneOnDrag,set_cloneOnDrag,true);
		addMember(l,"pressAndHoldDelay",get_pressAndHoldDelay,set_pressAndHoldDelay,true);
		addMember(l,"interactable",get_interactable,set_interactable,true);
		addMember(l,"draggedItems",get_draggedItems,set_draggedItems,false);
		createTypeMetatable(l,null, typeof(UIDragDropItem),typeof(UnityEngine.MonoBehaviour));
	}
}
