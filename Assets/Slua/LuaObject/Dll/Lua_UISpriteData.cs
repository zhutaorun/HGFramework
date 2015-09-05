using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISpriteData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UISpriteData o;
			o=new UISpriteData();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetRect(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetRect(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPadding(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetPadding(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetBorder(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetBorder(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CopyFrom(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			UISpriteData a1;
			checkType(l,2,out a1);
			self.CopyFrom(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CopyBorderFrom(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			UISpriteData a1;
			checkType(l,2,out a1);
			self.CopyBorderFrom(a1);
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
			UISpriteData self=(UISpriteData)checkSelf(l);
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
			UISpriteData self=(UISpriteData)checkSelf(l);
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
	static public int get_x(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.x);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.x=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.y);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.y=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.width);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.width=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.height);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.height=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_borderLeft(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.borderLeft);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_borderLeft(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.borderLeft=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_borderRight(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.borderRight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_borderRight(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.borderRight=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_borderTop(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.borderTop);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_borderTop(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.borderTop=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_borderBottom(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.borderBottom);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_borderBottom(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.borderBottom=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_paddingLeft(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.paddingLeft);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_paddingLeft(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.paddingLeft=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_paddingRight(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.paddingRight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_paddingRight(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.paddingRight=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_paddingTop(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.paddingTop);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_paddingTop(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.paddingTop=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_paddingBottom(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.paddingBottom);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_paddingBottom(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.paddingBottom=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasBorder(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.hasBorder);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasPadding(IntPtr l) {
		try {
			UISpriteData self=(UISpriteData)checkSelf(l);
			pushValue(l,self.hasPadding);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISpriteData");
		addMember(l,SetRect);
		addMember(l,SetPadding);
		addMember(l,SetBorder);
		addMember(l,CopyFrom);
		addMember(l,CopyBorderFrom);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"borderLeft",get_borderLeft,set_borderLeft,true);
		addMember(l,"borderRight",get_borderRight,set_borderRight,true);
		addMember(l,"borderTop",get_borderTop,set_borderTop,true);
		addMember(l,"borderBottom",get_borderBottom,set_borderBottom,true);
		addMember(l,"paddingLeft",get_paddingLeft,set_paddingLeft,true);
		addMember(l,"paddingRight",get_paddingRight,set_paddingRight,true);
		addMember(l,"paddingTop",get_paddingTop,set_paddingTop,true);
		addMember(l,"paddingBottom",get_paddingBottom,set_paddingBottom,true);
		addMember(l,"hasBorder",get_hasBorder,null,true);
		addMember(l,"hasPadding",get_hasPadding,null,true);
		createTypeMetatable(l,constructor, typeof(UISpriteData));
	}
}
