using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_InvAttachmentPoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Attach(IntPtr l) {
		try {
			InvAttachmentPoint self=(InvAttachmentPoint)checkSelf(l);
			UnityEngine.GameObject a1;
			checkType(l,2,out a1);
			var ret=self.Attach(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_slot(IntPtr l) {
		try {
			InvAttachmentPoint self=(InvAttachmentPoint)checkSelf(l);
			pushEnum(l,(int)self.slot);
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
			InvAttachmentPoint self=(InvAttachmentPoint)checkSelf(l);
			InvBaseItem.Slot v;
			checkEnum(l,2,out v);
			self.slot=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"InvAttachmentPoint");
		addMember(l,Attach);
		addMember(l,"slot",get_slot,set_slot,true);
		createTypeMetatable(l,null, typeof(InvAttachmentPoint),typeof(UnityEngine.MonoBehaviour));
	}
}
