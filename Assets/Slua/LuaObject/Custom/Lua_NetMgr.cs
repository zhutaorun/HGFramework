using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_NetMgr : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Connect(IntPtr l) {
		try {
			NetMgr self=(NetMgr)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.Connect(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Disconnect(IntPtr l) {
		try {
			NetMgr self=(NetMgr)checkSelf(l);
			self.Disconnect();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SendNetMsg(IntPtr l) {
		try {
			NetMgr self=(NetMgr)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Byte[] a2;
			checkType(l,3,out a2);
			self.SendNetMsg(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"NetMgr");
		addMember(l,Connect);
		addMember(l,Disconnect);
		addMember(l,SendNetMsg);
		createTypeMetatable(l,null, typeof(NetMgr),typeof(Singleton<NetMgr>));
	}
}
