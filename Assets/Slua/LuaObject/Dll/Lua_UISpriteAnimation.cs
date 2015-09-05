using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISpriteAnimation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RebuildSpriteList(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			self.RebuildSpriteList();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			self.Play();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Pause(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			self.Pause();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetToBeginning(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			self.ResetToBeginning();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frames(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			pushValue(l,self.frames);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_framesPerSecond(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			pushValue(l,self.framesPerSecond);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_framesPerSecond(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.framesPerSecond=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_namePrefix(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			pushValue(l,self.namePrefix);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_namePrefix(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.namePrefix=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loop(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			pushValue(l,self.loop);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loop(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.loop=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPlaying(IntPtr l) {
		try {
			UISpriteAnimation self=(UISpriteAnimation)checkSelf(l);
			pushValue(l,self.isPlaying);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISpriteAnimation");
		addMember(l,RebuildSpriteList);
		addMember(l,Play);
		addMember(l,Pause);
		addMember(l,ResetToBeginning);
		addMember(l,"frames",get_frames,null,true);
		addMember(l,"framesPerSecond",get_framesPerSecond,set_framesPerSecond,true);
		addMember(l,"namePrefix",get_namePrefix,set_namePrefix,true);
		addMember(l,"loop",get_loop,set_loop,true);
		addMember(l,"isPlaying",get_isPlaying,null,true);
		createTypeMetatable(l,null, typeof(UISpriteAnimation),typeof(UnityEngine.MonoBehaviour));
	}
}
