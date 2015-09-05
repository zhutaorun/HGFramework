using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Assertions_Must_MustExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MustBeTrue_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Boolean a1;
				checkType(l,1,out a1);
				UnityEngine.Assertions.Must.MustExtensions.MustBeTrue(a1);
				return 0;
			}
			else if(argc==2){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				UnityEngine.Assertions.Must.MustExtensions.MustBeTrue(a1,a2);
				return 0;
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
	static public int MustBeFalse_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Boolean a1;
				checkType(l,1,out a1);
				UnityEngine.Assertions.Must.MustExtensions.MustBeFalse(a1);
				return 0;
			}
			else if(argc==2){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				UnityEngine.Assertions.Must.MustExtensions.MustBeFalse(a1,a2);
				return 0;
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
	static public int MustBeApproximatelyEqual_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Assertions.Must.MustExtensions.MustBeApproximatelyEqual(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(float))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Assertions.Must.MustExtensions.MustBeApproximatelyEqual(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(string))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.String a3;
				checkType(l,3,out a3);
				UnityEngine.Assertions.Must.MustExtensions.MustBeApproximatelyEqual(a1,a2,a3);
				return 0;
			}
			else if(argc==4){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.String a4;
				checkType(l,4,out a4);
				UnityEngine.Assertions.Must.MustExtensions.MustBeApproximatelyEqual(a1,a2,a3,a4);
				return 0;
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
	static public int MustNotBeApproximatelyEqual_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Assertions.Must.MustExtensions.MustNotBeApproximatelyEqual(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(float))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Assertions.Must.MustExtensions.MustNotBeApproximatelyEqual(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(string))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.String a3;
				checkType(l,3,out a3);
				UnityEngine.Assertions.Must.MustExtensions.MustNotBeApproximatelyEqual(a1,a2,a3);
				return 0;
			}
			else if(argc==4){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.String a4;
				checkType(l,4,out a4);
				UnityEngine.Assertions.Must.MustExtensions.MustNotBeApproximatelyEqual(a1,a2,a3,a4);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Assertions.Must.MustExtensions");
		addMember(l,MustBeTrue_s);
		addMember(l,MustBeFalse_s);
		addMember(l,MustBeApproximatelyEqual_s);
		addMember(l,MustNotBeApproximatelyEqual_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Assertions.Must.MustExtensions));
	}
}
