using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LuaBehaviour : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_table(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.table);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_table(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			SLua.LuaTable v;
			checkType(l,2,out v);
			self.table=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_className(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.className);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_className(IntPtr l) {
		try {
			LuaBehaviour self=(LuaBehaviour)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.className=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LuaBehaviour");
		addMember(l,"table",get_table,set_table,true);
		addMember(l,"className",get_className,set_className,true);
		createTypeMetatable(l,null, typeof(LuaBehaviour),typeof(UnityEngine.MonoBehaviour));
	}
}
