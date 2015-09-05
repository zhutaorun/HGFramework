using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISnapshotPoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOrthographic(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			pushValue(l,self.isOrthographic);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isOrthographic(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isOrthographic=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nearClip(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			pushValue(l,self.nearClip);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nearClip(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.nearClip=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_farClip(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			pushValue(l,self.farClip);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_farClip(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.farClip=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fieldOfView(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			pushValue(l,self.fieldOfView);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fieldOfView(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.fieldOfView=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthoSize(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			pushValue(l,self.orthoSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthoSize(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.orthoSize=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_thumbnail(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			pushValue(l,self.thumbnail);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_thumbnail(IntPtr l) {
		try {
			UISnapshotPoint self=(UISnapshotPoint)checkSelf(l);
			UnityEngine.Texture2D v;
			checkType(l,2,out v);
			self.thumbnail=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISnapshotPoint");
		addMember(l,"isOrthographic",get_isOrthographic,set_isOrthographic,true);
		addMember(l,"nearClip",get_nearClip,set_nearClip,true);
		addMember(l,"farClip",get_farClip,set_farClip,true);
		addMember(l,"fieldOfView",get_fieldOfView,set_fieldOfView,true);
		addMember(l,"orthoSize",get_orthoSize,set_orthoSize,true);
		addMember(l,"thumbnail",get_thumbnail,set_thumbnail,true);
		createTypeMetatable(l,null, typeof(UISnapshotPoint),typeof(UnityEngine.MonoBehaviour));
	}
}
