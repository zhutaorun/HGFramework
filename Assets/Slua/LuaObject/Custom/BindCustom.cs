using System;
namespace SLua {
	[LuaBinder(3)]
	public class BindCustom {
		public static void Bind(IntPtr l) {
			Lua_ConfigMgr.reg(l);
			Lua_LuaBehaviour.reg(l);
			Lua_ResMgr.reg(l);
			Lua_SceneMgr.reg(l);
			Lua_Tel.reg(l);
			Lua_Custom.reg(l);
			Lua_Deleg.reg(l);
			Lua_foostruct.reg(l);
			Lua_SLuaTest.reg(l);
			Lua_System_Collections_Generic_List_1_int.reg(l);
			Lua_XXList.reg(l);
			Lua_HelloWorld.reg(l);
			Lua_System_Collections_Generic_Dictionary_2_int_string.reg(l);
			Lua_System_String.reg(l);
		}
	}
}
