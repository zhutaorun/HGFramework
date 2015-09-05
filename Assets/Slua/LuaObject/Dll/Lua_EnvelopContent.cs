using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_EnvelopContent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Execute(IntPtr l) {
		try {
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			self.Execute();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetRoot(IntPtr l) {
		try {
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			pushValue(l,self.targetRoot);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetRoot(IntPtr l) {
		try {
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.targetRoot=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padLeft(IntPtr l) {
		try {
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			pushValue(l,self.padLeft);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padLeft(IntPtr l) {
		try {
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.padLeft=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padRight(IntPtr l) {
		try {
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			pushValue(l,self.padRight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padRight(IntPtr l) {
		try {
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.padRight=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padBottom(IntPtr l) {
		try {
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			pushValue(l,self.padBottom);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padBottom(IntPtr l) {
		try {
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.padBottom=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padTop(IntPtr l) {
		try {
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			pushValue(l,self.padTop);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padTop(IntPtr l) {
		try {
			EnvelopContent self=(EnvelopContent)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.padTop=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"EnvelopContent");
		addMember(l,Execute);
		addMember(l,"targetRoot",get_targetRoot,set_targetRoot,true);
		addMember(l,"padLeft",get_padLeft,set_padLeft,true);
		addMember(l,"padRight",get_padRight,set_padRight,true);
		addMember(l,"padBottom",get_padBottom,set_padBottom,true);
		addMember(l,"padTop",get_padTop,set_padTop,true);
		createTypeMetatable(l,null, typeof(EnvelopContent),typeof(UnityEngine.MonoBehaviour));
	}
}
