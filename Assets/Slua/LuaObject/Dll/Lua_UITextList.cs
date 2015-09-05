using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UITextList : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			self.Clear();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnScroll(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.OnScroll(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDrag(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			self.OnDrag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Add(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.Add(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textLabel(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			pushValue(l,self.textLabel);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textLabel(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			UILabel v;
			checkType(l,2,out v);
			self.textLabel=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollBar(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			pushValue(l,self.scrollBar);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollBar(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			UIProgressBar v;
			checkType(l,2,out v);
			self.scrollBar=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_style(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			pushEnum(l,(int)self.style);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_style(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			UITextList.Style v;
			checkEnum(l,2,out v);
			self.style=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_paragraphHistory(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			pushValue(l,self.paragraphHistory);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_paragraphHistory(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.paragraphHistory=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			pushValue(l,self.isValid);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollValue(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			pushValue(l,self.scrollValue);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollValue(IntPtr l) {
		try {
			UITextList self=(UITextList)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.scrollValue=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UITextList");
		addMember(l,Clear);
		addMember(l,OnScroll);
		addMember(l,OnDrag);
		addMember(l,Add);
		addMember(l,"textLabel",get_textLabel,set_textLabel,true);
		addMember(l,"scrollBar",get_scrollBar,set_scrollBar,true);
		addMember(l,"style",get_style,set_style,true);
		addMember(l,"paragraphHistory",get_paragraphHistory,set_paragraphHistory,true);
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"scrollValue",get_scrollValue,set_scrollValue,true);
		createTypeMetatable(l,null, typeof(UITextList),typeof(UnityEngine.MonoBehaviour));
	}
}
