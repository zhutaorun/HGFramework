using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_ByteReader : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			ByteReader o;
			if(matchType(l,argc,2,typeof(System.Byte[]))){
				System.Byte[] a1;
				checkType(l,2,out a1);
				o=new ByteReader(a1);
				pushValue(l,o);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.TextAsset))){
				UnityEngine.TextAsset a1;
				checkType(l,2,out a1);
				o=new ByteReader(a1);
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
	static public int ReadLine(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				ByteReader self=(ByteReader)checkSelf(l);
				var ret=self.ReadLine();
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				ByteReader self=(ByteReader)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=self.ReadLine(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadDictionary(IntPtr l) {
		try {
			ByteReader self=(ByteReader)checkSelf(l);
			var ret=self.ReadDictionary();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReadCSV(IntPtr l) {
		try {
			ByteReader self=(ByteReader)checkSelf(l);
			var ret=self.ReadCSV();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Open_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=ByteReader.Open(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canRead(IntPtr l) {
		try {
			ByteReader self=(ByteReader)checkSelf(l);
			pushValue(l,self.canRead);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ByteReader");
		addMember(l,ReadLine);
		addMember(l,ReadDictionary);
		addMember(l,ReadCSV);
		addMember(l,Open_s);
		addMember(l,"canRead",get_canRead,null,true);
		createTypeMetatable(l,constructor, typeof(ByteReader));
	}
}
