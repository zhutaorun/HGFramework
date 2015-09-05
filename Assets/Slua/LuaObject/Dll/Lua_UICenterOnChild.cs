using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UICenterOnChild : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Recenter(IntPtr l) {
		try {
			UICenterOnChild self=(UICenterOnChild)checkSelf(l);
			self.Recenter();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CenterOn(IntPtr l) {
		try {
			UICenterOnChild self=(UICenterOnChild)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			self.CenterOn(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_springStrength(IntPtr l) {
		try {
			UICenterOnChild self=(UICenterOnChild)checkSelf(l);
			pushValue(l,self.springStrength);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_springStrength(IntPtr l) {
		try {
			UICenterOnChild self=(UICenterOnChild)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.springStrength=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nextPageThreshold(IntPtr l) {
		try {
			UICenterOnChild self=(UICenterOnChild)checkSelf(l);
			pushValue(l,self.nextPageThreshold);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nextPageThreshold(IntPtr l) {
		try {
			UICenterOnChild self=(UICenterOnChild)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.nextPageThreshold=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onFinished(IntPtr l) {
		try {
			UICenterOnChild self=(UICenterOnChild)checkSelf(l);
			SpringPanel.OnFinished v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onFinished=v;
			else if(op==1) self.onFinished+=v;
			else if(op==2) self.onFinished-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCenter(IntPtr l) {
		try {
			UICenterOnChild self=(UICenterOnChild)checkSelf(l);
			UICenterOnChild.OnCenterCallback v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onCenter=v;
			else if(op==1) self.onCenter+=v;
			else if(op==2) self.onCenter-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_centeredObject(IntPtr l) {
		try {
			UICenterOnChild self=(UICenterOnChild)checkSelf(l);
			pushValue(l,self.centeredObject);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UICenterOnChild");
		addMember(l,Recenter);
		addMember(l,CenterOn);
		addMember(l,"springStrength",get_springStrength,set_springStrength,true);
		addMember(l,"nextPageThreshold",get_nextPageThreshold,set_nextPageThreshold,true);
		addMember(l,"onFinished",null,set_onFinished,true);
		addMember(l,"onCenter",null,set_onCenter,true);
		addMember(l,"centeredObject",get_centeredObject,null,true);
		createTypeMetatable(l,null, typeof(UICenterOnChild),typeof(UnityEngine.MonoBehaviour));
	}
}
