using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_ChatInput : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSubmit(IntPtr l) {
		try {
			ChatInput self=(ChatInput)checkSelf(l);
			self.OnSubmit();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textList(IntPtr l) {
		try {
			ChatInput self=(ChatInput)checkSelf(l);
			pushValue(l,self.textList);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textList(IntPtr l) {
		try {
			ChatInput self=(ChatInput)checkSelf(l);
			UITextList v;
			checkType(l,2,out v);
			self.textList=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillWithDummyData(IntPtr l) {
		try {
			ChatInput self=(ChatInput)checkSelf(l);
			pushValue(l,self.fillWithDummyData);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillWithDummyData(IntPtr l) {
		try {
			ChatInput self=(ChatInput)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.fillWithDummyData=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ChatInput");
		addMember(l,OnSubmit);
		addMember(l,"textList",get_textList,set_textList,true);
		addMember(l,"fillWithDummyData",get_fillWithDummyData,set_fillWithDummyData,true);
		createTypeMetatable(l,null, typeof(ChatInput),typeof(UnityEngine.MonoBehaviour));
	}
}
