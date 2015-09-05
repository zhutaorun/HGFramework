using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPlayAnimation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Play(a1);
				return 0;
			}
			else if(argc==3){
				UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.Play(a1,a2);
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
	static public int PlayForward(IntPtr l) {
		try {
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
			self.PlayForward();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PlayReverse(IntPtr l) {
		try {
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
			self.PlayReverse();
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
			pushValue(l,UIPlayAnimation.current);
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
			UIPlayAnimation v;
			checkType(l,2,out v);
			UIPlayAnimation.current=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		try {
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
			pushValue(l,self.target);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		try {
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
			UnityEngine.Animation v;
			checkType(l,2,out v);
			self.target=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animator(IntPtr l) {
		try {
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
			pushValue(l,self.animator);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_animator(IntPtr l) {
		try {
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
			UnityEngine.Animator v;
			checkType(l,2,out v);
			self.animator=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipName(IntPtr l) {
		try {
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
			pushValue(l,self.clipName);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipName(IntPtr l) {
		try {
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.clipName=v;
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
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
	static public int get_clearSelection(IntPtr l) {
		try {
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
			pushValue(l,self.clearSelection);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clearSelection(IntPtr l) {
		try {
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.clearSelection=v;
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
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
	static public int get_onFinished(IntPtr l) {
		try {
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
			UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
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
		getTypeTable(l,"UIPlayAnimation");
		addMember(l,Play);
		addMember(l,PlayForward);
		addMember(l,PlayReverse);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"animator",get_animator,set_animator,true);
		addMember(l,"clipName",get_clipName,set_clipName,true);
		addMember(l,"trigger",get_trigger,set_trigger,true);
		addMember(l,"playDirection",get_playDirection,set_playDirection,true);
		addMember(l,"resetOnPlay",get_resetOnPlay,set_resetOnPlay,true);
		addMember(l,"clearSelection",get_clearSelection,set_clearSelection,true);
		addMember(l,"ifDisabledOnPlay",get_ifDisabledOnPlay,set_ifDisabledOnPlay,true);
		addMember(l,"disableWhenFinished",get_disableWhenFinished,set_disableWhenFinished,true);
		addMember(l,"onFinished",get_onFinished,set_onFinished,true);
		createTypeMetatable(l,null, typeof(UIPlayAnimation),typeof(UnityEngine.MonoBehaviour));
	}
}
