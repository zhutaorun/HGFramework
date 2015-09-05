using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIBasicSprite : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_centerType(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushEnum(l,(int)self.centerType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_centerType(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			UIBasicSprite.AdvancedType v;
			checkEnum(l,2,out v);
			self.centerType=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_leftType(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushEnum(l,(int)self.leftType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_leftType(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			UIBasicSprite.AdvancedType v;
			checkEnum(l,2,out v);
			self.leftType=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rightType(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushEnum(l,(int)self.rightType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rightType(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			UIBasicSprite.AdvancedType v;
			checkEnum(l,2,out v);
			self.rightType=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bottomType(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushEnum(l,(int)self.bottomType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bottomType(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			UIBasicSprite.AdvancedType v;
			checkEnum(l,2,out v);
			self.bottomType=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_topType(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushEnum(l,(int)self.topType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_topType(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			UIBasicSprite.AdvancedType v;
			checkEnum(l,2,out v);
			self.topType=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushEnum(l,(int)self.type);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			UIBasicSprite.Type v;
			checkEnum(l,2,out v);
			self.type=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flip(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushEnum(l,(int)self.flip);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flip(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			UIBasicSprite.Flip v;
			checkEnum(l,2,out v);
			self.flip=v;
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
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
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
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			UIBasicSprite.FillDirection v;
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
	static public int get_fillAmount(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushValue(l,self.fillAmount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillAmount(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.fillAmount=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushValue(l,self.minWidth);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushValue(l,self.minHeight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_invert(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushValue(l,self.invert);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_invert(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.invert=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasBorder(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushValue(l,self.hasBorder);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_premultipliedAlpha(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushValue(l,self.premultipliedAlpha);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelSize(IntPtr l) {
		try {
			UIBasicSprite self=(UIBasicSprite)checkSelf(l);
			pushValue(l,self.pixelSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIBasicSprite");
		addMember(l,"centerType",get_centerType,set_centerType,true);
		addMember(l,"leftType",get_leftType,set_leftType,true);
		addMember(l,"rightType",get_rightType,set_rightType,true);
		addMember(l,"bottomType",get_bottomType,set_bottomType,true);
		addMember(l,"topType",get_topType,set_topType,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"flip",get_flip,set_flip,true);
		addMember(l,"fillDirection",get_fillDirection,set_fillDirection,true);
		addMember(l,"fillAmount",get_fillAmount,set_fillAmount,true);
		addMember(l,"minWidth",get_minWidth,null,true);
		addMember(l,"minHeight",get_minHeight,null,true);
		addMember(l,"invert",get_invert,set_invert,true);
		addMember(l,"hasBorder",get_hasBorder,null,true);
		addMember(l,"premultipliedAlpha",get_premultipliedAlpha,null,true);
		addMember(l,"pixelSize",get_pixelSize,null,true);
		createTypeMetatable(l,null, typeof(UIBasicSprite),typeof(UIWidget));
	}
}
