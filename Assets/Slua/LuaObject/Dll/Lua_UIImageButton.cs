using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIImageButton : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		try {
			UIImageButton self=(UIImageButton)checkSelf(l);
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
			UIImageButton self=(UIImageButton)checkSelf(l);
			UISprite v;
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
	static public int get_normalSprite(IntPtr l) {
		try {
			UIImageButton self=(UIImageButton)checkSelf(l);
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
			UIImageButton self=(UIImageButton)checkSelf(l);
			System.String v;
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
	static public int get_hoverSprite(IntPtr l) {
		try {
			UIImageButton self=(UIImageButton)checkSelf(l);
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
			UIImageButton self=(UIImageButton)checkSelf(l);
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
			UIImageButton self=(UIImageButton)checkSelf(l);
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
			UIImageButton self=(UIImageButton)checkSelf(l);
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
			UIImageButton self=(UIImageButton)checkSelf(l);
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
			UIImageButton self=(UIImageButton)checkSelf(l);
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
	static public int get_pixelSnap(IntPtr l) {
		try {
			UIImageButton self=(UIImageButton)checkSelf(l);
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
			UIImageButton self=(UIImageButton)checkSelf(l);
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
	static public int get_isEnabled(IntPtr l) {
		try {
			UIImageButton self=(UIImageButton)checkSelf(l);
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
			UIImageButton self=(UIImageButton)checkSelf(l);
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIImageButton");
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"normalSprite",get_normalSprite,set_normalSprite,true);
		addMember(l,"hoverSprite",get_hoverSprite,set_hoverSprite,true);
		addMember(l,"pressedSprite",get_pressedSprite,set_pressedSprite,true);
		addMember(l,"disabledSprite",get_disabledSprite,set_disabledSprite,true);
		addMember(l,"pixelSnap",get_pixelSnap,set_pixelSnap,true);
		addMember(l,"isEnabled",get_isEnabled,set_isEnabled,true);
		createTypeMetatable(l,null, typeof(UIImageButton),typeof(UnityEngine.MonoBehaviour));
	}
}
