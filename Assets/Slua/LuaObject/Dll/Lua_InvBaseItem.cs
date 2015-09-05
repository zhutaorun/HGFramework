using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_InvBaseItem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			InvBaseItem o;
			o=new InvBaseItem();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_id16(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			pushValue(l,self.id16);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_id16(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.id16=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			pushValue(l,self.name);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.name=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_description(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			pushValue(l,self.description);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_description(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.description=v;
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
			InvBaseItem self=(InvBaseItem)checkSelf(l);
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
			InvBaseItem self=(InvBaseItem)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minItemLevel(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			pushValue(l,self.minItemLevel);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minItemLevel(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.minItemLevel=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxItemLevel(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			pushValue(l,self.maxItemLevel);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxItemLevel(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.maxItemLevel=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stats(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			pushValue(l,self.stats);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stats(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			System.Collections.Generic.List<InvStat> v;
			checkType(l,2,out v);
			self.stats=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attachment(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			pushValue(l,self.attachment);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_attachment(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			UnityEngine.GameObject v;
			checkType(l,2,out v);
			self.attachment=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			pushValue(l,self.color);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.color=v;
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
			InvBaseItem self=(InvBaseItem)checkSelf(l);
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
			InvBaseItem self=(InvBaseItem)checkSelf(l);
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
	static public int get_iconName(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			pushValue(l,self.iconName);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_iconName(IntPtr l) {
		try {
			InvBaseItem self=(InvBaseItem)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.iconName=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"InvBaseItem");
		addMember(l,"id16",get_id16,set_id16,true);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"description",get_description,set_description,true);
		addMember(l,"slot",get_slot,set_slot,true);
		addMember(l,"minItemLevel",get_minItemLevel,set_minItemLevel,true);
		addMember(l,"maxItemLevel",get_maxItemLevel,set_maxItemLevel,true);
		addMember(l,"stats",get_stats,set_stats,true);
		addMember(l,"attachment",get_attachment,set_attachment,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"iconAtlas",get_iconAtlas,set_iconAtlas,true);
		addMember(l,"iconName",get_iconName,set_iconName,true);
		createTypeMetatable(l,constructor, typeof(InvBaseItem));
	}
}
