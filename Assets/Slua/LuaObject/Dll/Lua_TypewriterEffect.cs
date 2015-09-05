using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_TypewriterEffect : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetToBeginning(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			self.ResetToBeginning();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Finish(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			self.Finish();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		try {
			pushValue(l,TypewriterEffect.current);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		try {
			TypewriterEffect v;
			checkType(l,2,out v);
			TypewriterEffect.current=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_charsPerSecond(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			pushValue(l,self.charsPerSecond);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_charsPerSecond(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.charsPerSecond=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fadeInTime(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			pushValue(l,self.fadeInTime);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fadeInTime(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.fadeInTime=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delayOnPeriod(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			pushValue(l,self.delayOnPeriod);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delayOnPeriod(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.delayOnPeriod=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delayOnNewLine(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			pushValue(l,self.delayOnNewLine);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delayOnNewLine(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.delayOnNewLine=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollView(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			pushValue(l,self.scrollView);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollView(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			UIScrollView v;
			checkType(l,2,out v);
			self.scrollView=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keepFullDimensions(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			pushValue(l,self.keepFullDimensions);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keepFullDimensions(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.keepFullDimensions=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onFinished(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			pushValue(l,self.onFinished);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onFinished(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onFinished=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isActive(IntPtr l) {
		try {
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			pushValue(l,self.isActive);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"TypewriterEffect");
		addMember(l,ResetToBeginning);
		addMember(l,Finish);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"charsPerSecond",get_charsPerSecond,set_charsPerSecond,true);
		addMember(l,"fadeInTime",get_fadeInTime,set_fadeInTime,true);
		addMember(l,"delayOnPeriod",get_delayOnPeriod,set_delayOnPeriod,true);
		addMember(l,"delayOnNewLine",get_delayOnNewLine,set_delayOnNewLine,true);
		addMember(l,"scrollView",get_scrollView,set_scrollView,true);
		addMember(l,"keepFullDimensions",get_keepFullDimensions,set_keepFullDimensions,true);
		addMember(l,"onFinished",get_onFinished,set_onFinished,true);
		addMember(l,"isActive",get_isActive,null,true);
		createTypeMetatable(l,null, typeof(TypewriterEffect),typeof(UnityEngine.MonoBehaviour));
	}
}
