using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_InvGameItem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			InvGameItem o;
			if(argc==2){
				System.Int32 a1;
				checkType(l,2,out a1);
				o=new InvGameItem(a1);
				pushValue(l,o);
				return 1;
			}
			else if(argc==3){
				System.Int32 a1;
				checkType(l,2,out a1);
				InvBaseItem a2;
				checkType(l,3,out a2);
				o=new InvGameItem(a1,a2);
				pushValue(l,o);
				return 1;
			}
			LuaDLL.luaL_error(l,"New object failed.");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateStats(IntPtr l) {
		try {
			InvGameItem self=(InvGameItem)checkSelf(l);
			var ret=self.CalculateStats();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_quality(IntPtr l) {
		try {
			InvGameItem self=(InvGameItem)checkSelf(l);
			pushEnum(l,(int)self.quality);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_quality(IntPtr l) {
		try {
			InvGameItem self=(InvGameItem)checkSelf(l);
			InvGameItem.Quality v;
			checkEnum(l,2,out v);
			self.quality=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_itemLevel(IntPtr l) {
		try {
			InvGameItem self=(InvGameItem)checkSelf(l);
			pushValue(l,self.itemLevel);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_itemLevel(IntPtr l) {
		try {
			InvGameItem self=(InvGameItem)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.itemLevel=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baseItemID(IntPtr l) {
		try {
			InvGameItem self=(InvGameItem)checkSelf(l);
			pushValue(l,self.baseItemID);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baseItem(IntPtr l) {
		try {
			InvGameItem self=(InvGameItem)checkSelf(l);
			pushValue(l,self.baseItem);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		try {
			InvGameItem self=(InvGameItem)checkSelf(l);
			pushValue(l,self.name);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_statMultiplier(IntPtr l) {
		try {
			InvGameItem self=(InvGameItem)checkSelf(l);
			pushValue(l,self.statMultiplier);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		try {
			InvGameItem self=(InvGameItem)checkSelf(l);
			pushValue(l,self.color);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"InvGameItem");
		addMember(l,CalculateStats);
		addMember(l,"quality",get_quality,set_quality,true);
		addMember(l,"itemLevel",get_itemLevel,set_itemLevel,true);
		addMember(l,"baseItemID",get_baseItemID,null,true);
		addMember(l,"baseItem",get_baseItem,null,true);
		addMember(l,"name",get_name,null,true);
		addMember(l,"statMultiplier",get_statMultiplier,null,true);
		addMember(l,"color",get_color,null,true);
		createTypeMetatable(l,constructor, typeof(InvGameItem));
	}
}
