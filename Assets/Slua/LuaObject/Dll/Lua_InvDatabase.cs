using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_InvDatabase : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindByID_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=InvDatabase.FindByID(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindByName_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=InvDatabase.FindByName(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindItemID_s(IntPtr l) {
		try {
			InvBaseItem a1;
			checkType(l,1,out a1);
			var ret=InvDatabase.FindItemID(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_databaseID(IntPtr l) {
		try {
			InvDatabase self=(InvDatabase)checkSelf(l);
			pushValue(l,self.databaseID);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_databaseID(IntPtr l) {
		try {
			InvDatabase self=(InvDatabase)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.databaseID=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_items(IntPtr l) {
		try {
			InvDatabase self=(InvDatabase)checkSelf(l);
			pushValue(l,self.items);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_items(IntPtr l) {
		try {
			InvDatabase self=(InvDatabase)checkSelf(l);
			System.Collections.Generic.List<InvBaseItem> v;
			checkType(l,2,out v);
			self.items=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_iconAtlas(IntPtr l) {
		try {
			InvDatabase self=(InvDatabase)checkSelf(l);
			pushValue(l,self.iconAtlas);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_iconAtlas(IntPtr l) {
		try {
			InvDatabase self=(InvDatabase)checkSelf(l);
			UIAtlas v;
			checkType(l,2,out v);
			self.iconAtlas=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_list(IntPtr l) {
		try {
			pushValue(l,InvDatabase.list);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"InvDatabase");
		addMember(l,FindByID_s);
		addMember(l,FindByName_s);
		addMember(l,FindItemID_s);
		addMember(l,"databaseID",get_databaseID,set_databaseID,true);
		addMember(l,"items",get_items,set_items,true);
		addMember(l,"iconAtlas",get_iconAtlas,set_iconAtlas,true);
		addMember(l,"list",get_list,null,false);
		createTypeMetatable(l,null, typeof(InvDatabase),typeof(UnityEngine.MonoBehaviour));
	}
}
