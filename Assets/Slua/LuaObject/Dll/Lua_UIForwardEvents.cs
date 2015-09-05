using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIForwardEvents : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
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
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			UnityEngine.GameObject v;
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
	static public int get_onHover(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			pushValue(l,self.onHover);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onHover(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.onHover=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onPress(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			pushValue(l,self.onPress);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onPress(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.onPress=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onClick(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			pushValue(l,self.onClick);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onClick(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.onClick=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDoubleClick(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			pushValue(l,self.onDoubleClick);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDoubleClick(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.onDoubleClick=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onSelect(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			pushValue(l,self.onSelect);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSelect(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.onSelect=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDrag(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			pushValue(l,self.onDrag);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDrag(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.onDrag=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDrop(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			pushValue(l,self.onDrop);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDrop(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.onDrop=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onSubmit(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			pushValue(l,self.onSubmit);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSubmit(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.onSubmit=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onScroll(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			pushValue(l,self.onScroll);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onScroll(IntPtr l) {
		try {
			UIForwardEvents self=(UIForwardEvents)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.onScroll=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIForwardEvents");
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"onHover",get_onHover,set_onHover,true);
		addMember(l,"onPress",get_onPress,set_onPress,true);
		addMember(l,"onClick",get_onClick,set_onClick,true);
		addMember(l,"onDoubleClick",get_onDoubleClick,set_onDoubleClick,true);
		addMember(l,"onSelect",get_onSelect,set_onSelect,true);
		addMember(l,"onDrag",get_onDrag,set_onDrag,true);
		addMember(l,"onDrop",get_onDrop,set_onDrop,true);
		addMember(l,"onSubmit",get_onSubmit,set_onSubmit,true);
		addMember(l,"onScroll",get_onScroll,set_onScroll,true);
		createTypeMetatable(l,null, typeof(UIForwardEvents),typeof(UnityEngine.MonoBehaviour));
	}
}
