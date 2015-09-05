using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_DownloadTexture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_url(IntPtr l) {
		try {
			DownloadTexture self=(DownloadTexture)checkSelf(l);
			pushValue(l,self.url);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_url(IntPtr l) {
		try {
			DownloadTexture self=(DownloadTexture)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.url=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelPerfect(IntPtr l) {
		try {
			DownloadTexture self=(DownloadTexture)checkSelf(l);
			pushValue(l,self.pixelPerfect);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelPerfect(IntPtr l) {
		try {
			DownloadTexture self=(DownloadTexture)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.pixelPerfect=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"DownloadTexture");
		addMember(l,"url",get_url,set_url,true);
		addMember(l,"pixelPerfect",get_pixelPerfect,set_pixelPerfect,true);
		createTypeMetatable(l,null, typeof(DownloadTexture),typeof(UnityEngine.MonoBehaviour));
	}
}
