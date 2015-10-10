using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIEventListener : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Get_s(IntPtr l) {
		try {
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			var ret=UIEventListener.Get(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_parameter(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.parameter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_parameter(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			System.Object v;
			checkType(l,2,out v);
			self.parameter=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSubmit(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onSubmit=v;
			else if(op==1) self.onSubmit+=v;
			else if(op==2) self.onSubmit-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onClick(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onClick=v;
			else if(op==1) self.onClick+=v;
			else if(op==2) self.onClick-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDoubleClick(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDoubleClick=v;
			else if(op==1) self.onDoubleClick+=v;
			else if(op==2) self.onDoubleClick-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onHover(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.BoolDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onHover=v;
			else if(op==1) self.onHover+=v;
			else if(op==2) self.onHover-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onPress(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.BoolDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onPress=v;
			else if(op==1) self.onPress+=v;
			else if(op==2) self.onPress-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSelect(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.BoolDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onSelect=v;
			else if(op==1) self.onSelect+=v;
			else if(op==2) self.onSelect-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onScroll(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.FloatDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onScroll=v;
			else if(op==1) self.onScroll+=v;
			else if(op==2) self.onScroll-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragStart(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDragStart=v;
			else if(op==1) self.onDragStart+=v;
			else if(op==2) self.onDragStart-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDrag(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.VectorDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDrag=v;
			else if(op==1) self.onDrag+=v;
			else if(op==2) self.onDrag-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragOver(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDragOver=v;
			else if(op==1) self.onDragOver+=v;
			else if(op==2) self.onDragOver-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragOut(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDragOut=v;
			else if(op==1) self.onDragOut+=v;
			else if(op==2) self.onDragOut-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragEnd(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.VoidDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDragEnd=v;
			else if(op==1) self.onDragEnd+=v;
			else if(op==2) self.onDragEnd-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDrop(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.ObjectDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDrop=v;
			else if(op==1) self.onDrop+=v;
			else if(op==2) self.onDrop-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onKey(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.KeyCodeDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onKey=v;
			else if(op==1) self.onKey+=v;
			else if(op==2) self.onKey-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onTooltip(IntPtr l) {
		try {
			UIEventListener self=(UIEventListener)checkSelf(l);
			UIEventListener.BoolDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onTooltip=v;
			else if(op==1) self.onTooltip+=v;
			else if(op==2) self.onTooltip-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIEventListener");
		addMember(l,Get_s);
		addMember(l,"parameter",get_parameter,set_parameter,true);
		addMember(l,"onSubmit",null,set_onSubmit,true);
		addMember(l,"onClick",null,set_onClick,true);
		addMember(l,"onDoubleClick",null,set_onDoubleClick,true);
		addMember(l,"onHover",null,set_onHover,true);
		addMember(l,"onPress",null,set_onPress,true);
		addMember(l,"onSelect",null,set_onSelect,true);
		addMember(l,"onScroll",null,set_onScroll,true);
		addMember(l,"onDragStart",null,set_onDragStart,true);
		addMember(l,"onDrag",null,set_onDrag,true);
		addMember(l,"onDragOver",null,set_onDragOver,true);
		addMember(l,"onDragOut",null,set_onDragOut,true);
		addMember(l,"onDragEnd",null,set_onDragEnd,true);
		addMember(l,"onDrop",null,set_onDrop,true);
		addMember(l,"onKey",null,set_onKey,true);
		addMember(l,"onTooltip",null,set_onTooltip,true);
		createTypeMetatable(l,null, typeof(UIEventListener),typeof(UnityEngine.MonoBehaviour));
	}
}
