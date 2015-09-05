using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIWrapContent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SortBasedOnScrollMovement(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			self.SortBasedOnScrollMovement();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SortAlphabetically(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			self.SortAlphabetically();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WrapContent(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			self.WrapContent();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_itemSize(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			pushValue(l,self.itemSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_itemSize(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.itemSize=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cullContent(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			pushValue(l,self.cullContent);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cullContent(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.cullContent=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minIndex(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			pushValue(l,self.minIndex);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minIndex(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.minIndex=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxIndex(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			pushValue(l,self.maxIndex);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxIndex(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.maxIndex=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onInitializeItem(IntPtr l) {
		try {
			UIWrapContent self=(UIWrapContent)checkSelf(l);
			UIWrapContent.OnInitializeItem v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onInitializeItem=v;
			else if(op==1) self.onInitializeItem+=v;
			else if(op==2) self.onInitializeItem-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIWrapContent");
		addMember(l,SortBasedOnScrollMovement);
		addMember(l,SortAlphabetically);
		addMember(l,WrapContent);
		addMember(l,"itemSize",get_itemSize,set_itemSize,true);
		addMember(l,"cullContent",get_cullContent,set_cullContent,true);
		addMember(l,"minIndex",get_minIndex,set_minIndex,true);
		addMember(l,"maxIndex",get_maxIndex,set_maxIndex,true);
		addMember(l,"onInitializeItem",null,set_onInitializeItem,true);
		createTypeMetatable(l,null, typeof(UIWrapContent),typeof(UnityEngine.MonoBehaviour));
	}
}
