using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIEventTrigger : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		try {
			pushValue(l,UIEventTrigger.current);
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
			UIEventTrigger v;
			checkType(l,2,out v);
			UIEventTrigger.current=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onHoverOver(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			pushValue(l,self.onHoverOver);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onHoverOver(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onHoverOver=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onHoverOut(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			pushValue(l,self.onHoverOut);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onHoverOut(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onHoverOut=v;
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
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
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
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
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
	static public int get_onRelease(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			pushValue(l,self.onRelease);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onRelease(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onRelease=v;
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
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
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
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
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
	static public int get_onDeselect(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			pushValue(l,self.onDeselect);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDeselect(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onDeselect=v;
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
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
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
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
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
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
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
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
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
	static public int get_onDragStart(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			pushValue(l,self.onDragStart);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragStart(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onDragStart=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDragEnd(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			pushValue(l,self.onDragEnd);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragEnd(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onDragEnd=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDragOver(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			pushValue(l,self.onDragOver);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragOver(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onDragOver=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDragOut(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			pushValue(l,self.onDragOut);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragOut(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onDragOut=v;
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
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
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
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
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
	static public int get_isColliderEnabled(IntPtr l) {
		try {
			UIEventTrigger self=(UIEventTrigger)checkSelf(l);
			pushValue(l,self.isColliderEnabled);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIEventTrigger");
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"onHoverOver",get_onHoverOver,set_onHoverOver,true);
		addMember(l,"onHoverOut",get_onHoverOut,set_onHoverOut,true);
		addMember(l,"onPress",get_onPress,set_onPress,true);
		addMember(l,"onRelease",get_onRelease,set_onRelease,true);
		addMember(l,"onSelect",get_onSelect,set_onSelect,true);
		addMember(l,"onDeselect",get_onDeselect,set_onDeselect,true);
		addMember(l,"onClick",get_onClick,set_onClick,true);
		addMember(l,"onDoubleClick",get_onDoubleClick,set_onDoubleClick,true);
		addMember(l,"onDragStart",get_onDragStart,set_onDragStart,true);
		addMember(l,"onDragEnd",get_onDragEnd,set_onDragEnd,true);
		addMember(l,"onDragOver",get_onDragOver,set_onDragOver,true);
		addMember(l,"onDragOut",get_onDragOut,set_onDragOut,true);
		addMember(l,"onDrag",get_onDrag,set_onDrag,true);
		addMember(l,"isColliderEnabled",get_isColliderEnabled,null,true);
		createTypeMetatable(l,null, typeof(UIEventTrigger),typeof(UnityEngine.MonoBehaviour));
	}
}
