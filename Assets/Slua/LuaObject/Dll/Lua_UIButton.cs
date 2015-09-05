using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIButton : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UIButton o;
			o=new UIButton();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetState(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			UIButtonColor.State a1;
			checkEnum(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetState(a1,a2);
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
			pushValue(l,UIButton.current);
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
			UIButton v;
			checkType(l,2,out v);
			UIButton.current=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragHighlight(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			pushValue(l,self.dragHighlight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragHighlight(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.dragHighlight=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hoverSprite(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			pushValue(l,self.hoverSprite);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hoverSprite(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.hoverSprite=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedSprite(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			pushValue(l,self.pressedSprite);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedSprite(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.pressedSprite=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledSprite(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			pushValue(l,self.disabledSprite);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledSprite(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.disabledSprite=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hoverSprite2D(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			pushValue(l,self.hoverSprite2D);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hoverSprite2D(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.hoverSprite2D=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedSprite2D(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			pushValue(l,self.pressedSprite2D);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedSprite2D(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.pressedSprite2D=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledSprite2D(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			pushValue(l,self.disabledSprite2D);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledSprite2D(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.disabledSprite2D=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelSnap(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			pushValue(l,self.pixelSnap);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelSnap(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.pixelSnap=v;
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
			UIButton self=(UIButton)checkSelf(l);
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
			UIButton self=(UIButton)checkSelf(l);
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
	static public int get_isEnabled(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			pushValue(l,self.isEnabled);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isEnabled(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isEnabled=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalSprite(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			pushValue(l,self.normalSprite);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalSprite(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.normalSprite=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalSprite2D(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			pushValue(l,self.normalSprite2D);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalSprite2D(IntPtr l) {
		try {
			UIButton self=(UIButton)checkSelf(l);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.normalSprite2D=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIButton");
		addMember(l,SetState);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"dragHighlight",get_dragHighlight,set_dragHighlight,true);
		addMember(l,"hoverSprite",get_hoverSprite,set_hoverSprite,true);
		addMember(l,"pressedSprite",get_pressedSprite,set_pressedSprite,true);
		addMember(l,"disabledSprite",get_disabledSprite,set_disabledSprite,true);
		addMember(l,"hoverSprite2D",get_hoverSprite2D,set_hoverSprite2D,true);
		addMember(l,"pressedSprite2D",get_pressedSprite2D,set_pressedSprite2D,true);
		addMember(l,"disabledSprite2D",get_disabledSprite2D,set_disabledSprite2D,true);
		addMember(l,"pixelSnap",get_pixelSnap,set_pixelSnap,true);
		addMember(l,"onClick",get_onClick,set_onClick,true);
		addMember(l,"isEnabled",get_isEnabled,set_isEnabled,true);
		addMember(l,"normalSprite",get_normalSprite,set_normalSprite,true);
		addMember(l,"normalSprite2D",get_normalSprite2D,set_normalSprite2D,true);
		createTypeMetatable(l,constructor, typeof(UIButton),typeof(UIButtonColor));
	}
}
