using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_AnimatedAlpha : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alpha(IntPtr l) {
		try {
			AnimatedAlpha self=(AnimatedAlpha)checkSelf(l);
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
			AnimatedAlpha self=(AnimatedAlpha)checkSelf(l);
			System.Single v;
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
		getTypeTable(l,"AnimatedAlpha");
		addMember(l,"alpha",get_alpha,set_alpha,true);
		createTypeMetatable(l,null, typeof(AnimatedAlpha),typeof(UnityEngine.MonoBehaviour));
	}
}
