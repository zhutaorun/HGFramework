using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIProgressBar : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UIProgressBar o;
			o=new UIProgressBar();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ForceUpdate(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			self.ForceUpdate();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPan(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			self.OnPan(a1);
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
			pushValue(l,UIProgressBar.current);
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
			UIProgressBar v;
			checkType(l,2,out v);
			UIProgressBar.current=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragFinished(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			UIProgressBar.OnDragFinished v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDragFinished=v;
			else if(op==1) self.onDragFinished+=v;
			else if(op==2) self.onDragFinished-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_thumb(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			pushValue(l,self.thumb);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_thumb(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.thumb=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numberOfSteps(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			pushValue(l,self.numberOfSteps);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_numberOfSteps(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.numberOfSteps=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChange(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			pushValue(l,self.onChange);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onChange(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onChange=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTransform(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			pushValue(l,self.cachedTransform);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedCamera(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			pushValue(l,self.cachedCamera);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_foregroundWidget(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			pushValue(l,self.foregroundWidget);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_foregroundWidget(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			UIWidget v;
			checkType(l,2,out v);
			self.foregroundWidget=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundWidget(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			pushValue(l,self.backgroundWidget);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundWidget(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			UIWidget v;
			checkType(l,2,out v);
			self.backgroundWidget=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillDirection(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			pushEnum(l,(int)self.fillDirection);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillDirection(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			UIProgressBar.FillDirection v;
			checkEnum(l,2,out v);
			self.fillDirection=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			pushValue(l,self.value);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.value=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alpha(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			pushValue(l,self.alpha);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alpha(IntPtr l) {
		try {
			UIProgressBar self=(UIProgressBar)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.alpha=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIProgressBar");
		addMember(l,ForceUpdate);
		addMember(l,OnPan);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"onDragFinished",null,set_onDragFinished,true);
		addMember(l,"thumb",get_thumb,set_thumb,true);
		addMember(l,"numberOfSteps",get_numberOfSteps,set_numberOfSteps,true);
		addMember(l,"onChange",get_onChange,set_onChange,true);
		addMember(l,"cachedTransform",get_cachedTransform,null,true);
		addMember(l,"cachedCamera",get_cachedCamera,null,true);
		addMember(l,"foregroundWidget",get_foregroundWidget,set_foregroundWidget,true);
		addMember(l,"backgroundWidget",get_backgroundWidget,set_backgroundWidget,true);
		addMember(l,"fillDirection",get_fillDirection,set_fillDirection,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"alpha",get_alpha,set_alpha,true);
		createTypeMetatable(l,constructor, typeof(UIProgressBar),typeof(UIWidgetContainer));
	}
}
