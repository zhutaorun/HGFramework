using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPlayTween : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Play(a1);
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
			pushValue(l,UIPlayTween.current);
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
			UIPlayTween v;
			checkType(l,2,out v);
			UIPlayTween.current=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tweenTarget(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			pushValue(l,self.tweenTarget);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tweenTarget(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			UnityEngine.GameObject v;
			checkType(l,2,out v);
			self.tweenTarget=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tweenGroup(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			pushValue(l,self.tweenGroup);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tweenGroup(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.tweenGroup=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trigger(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			pushEnum(l,(int)self.trigger);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_trigger(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			AnimationOrTween.Trigger v;
			checkEnum(l,2,out v);
			self.trigger=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playDirection(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			pushEnum(l,(int)self.playDirection);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playDirection(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			AnimationOrTween.Direction v;
			checkEnum(l,2,out v);
			self.playDirection=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resetOnPlay(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			pushValue(l,self.resetOnPlay);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resetOnPlay(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.resetOnPlay=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resetIfDisabled(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			pushValue(l,self.resetIfDisabled);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resetIfDisabled(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.resetIfDisabled=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ifDisabledOnPlay(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			pushEnum(l,(int)self.ifDisabledOnPlay);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ifDisabledOnPlay(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			AnimationOrTween.EnableCondition v;
			checkEnum(l,2,out v);
			self.ifDisabledOnPlay=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disableWhenFinished(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			pushEnum(l,(int)self.disableWhenFinished);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disableWhenFinished(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			AnimationOrTween.DisableCondition v;
			checkEnum(l,2,out v);
			self.disableWhenFinished=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_includeChildren(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			pushValue(l,self.includeChildren);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_includeChildren(IntPtr l) {
		try {
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.includeChildren=v;
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
			UIPlayTween self=(UIPlayTween)checkSelf(l);
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
			UIPlayTween self=(UIPlayTween)checkSelf(l);
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIPlayTween");
		addMember(l,Play);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"tweenTarget",get_tweenTarget,set_tweenTarget,true);
		addMember(l,"tweenGroup",get_tweenGroup,set_tweenGroup,true);
		addMember(l,"trigger",get_trigger,set_trigger,true);
		addMember(l,"playDirection",get_playDirection,set_playDirection,true);
		addMember(l,"resetOnPlay",get_resetOnPlay,set_resetOnPlay,true);
		addMember(l,"resetIfDisabled",get_resetIfDisabled,set_resetIfDisabled,true);
		addMember(l,"ifDisabledOnPlay",get_ifDisabledOnPlay,set_ifDisabledOnPlay,true);
		addMember(l,"disableWhenFinished",get_disableWhenFinished,set_disableWhenFinished,true);
		addMember(l,"includeChildren",get_includeChildren,set_includeChildren,true);
		addMember(l,"onFinished",get_onFinished,set_onFinished,true);
		createTypeMetatable(l,null, typeof(UIPlayTween),typeof(UnityEngine.MonoBehaviour));
	}
}
