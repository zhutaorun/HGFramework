using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_NGUIText_GlyphInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			NGUIText.GlyphInfo o;
			o=new NGUIText.GlyphInfo();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_v0(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			pushValue(l,self.v0);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_v0(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.v0=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_v1(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			pushValue(l,self.v1);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_v1(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.v1=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_u0(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			pushValue(l,self.u0);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_u0(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.u0=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_u1(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			pushValue(l,self.u1);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_u1(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.u1=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_u2(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			pushValue(l,self.u2);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_u2(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.u2=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_u3(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			pushValue(l,self.u3);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_u3(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.u3=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_advance(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			pushValue(l,self.advance);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_advance(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.advance=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_channel(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			pushValue(l,self.channel);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_channel(IntPtr l) {
		try {
			NGUIText.GlyphInfo self=(NGUIText.GlyphInfo)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.channel=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"NGUIText.GlyphInfo");
		addMember(l,"v0",get_v0,set_v0,true);
		addMember(l,"v1",get_v1,set_v1,true);
		addMember(l,"u0",get_u0,set_u0,true);
		addMember(l,"u1",get_u1,set_u1,true);
		addMember(l,"u2",get_u2,set_u2,true);
		addMember(l,"u3",get_u3,set_u3,true);
		addMember(l,"advance",get_advance,set_advance,true);
		addMember(l,"channel",get_channel,set_channel,true);
		createTypeMetatable(l,constructor, typeof(NGUIText.GlyphInfo));
	}
}
