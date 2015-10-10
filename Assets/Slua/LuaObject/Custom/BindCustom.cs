using System;
using System.Collections.Generic;
namespace SLua {
	[LuaBinder(3)]
	public class BindCustom {
		public static Action<IntPtr>[] GetBindList() {
			Action<IntPtr>[] list= {
				Lua_Singleton_1_ConfigMgr.reg,
				Lua_ConfigMgr.reg,
				Lua_LuaBehaviour.reg,
				Lua_Singleton_1_NetMgr.reg,
				Lua_NetMgr.reg,
				Lua_Singleton_1_ResMgr.reg,
				Lua_ResMgr.reg,
				Lua_Singleton_1_SceneMgr.reg,
				Lua_SceneMgr.reg,
				Lua_Custom.reg,
				Lua_Deleg.reg,
				Lua_foostruct.reg,
				Lua_SLuaTest.reg,
				Lua_System_Collections_Generic_List_1_int.reg,
				Lua_XXList.reg,
				Lua_AbsClass.reg,
				Lua_HelloWorld.reg,
				Lua_System_Collections_Generic_Dictionary_2_int_string.reg,
				Lua_System_String.reg,
				Lua_UIEventListener.reg,
				Lua_UILabel.reg,
			};
			return list;
		}
	}
}
