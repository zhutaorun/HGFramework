using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIFont : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MarkAsChanged(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			self.MarkAsChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateUVRect(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			self.UpdateUVRect();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MatchSymbol(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.MatchSymbol(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddSymbol(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.AddSymbol(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveSymbol(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.RemoveSymbol(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RenameSymbol(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.RenameSymbol(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UsesSprite(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.UsesSprite(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CheckIfRelated_s(IntPtr l) {
		try {
			UIFont a1;
			checkType(l,1,out a1);
			UIFont a2;
			checkType(l,2,out a2);
			var ret=UIFont.CheckIfRelated(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bmFont(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.bmFont);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bmFont(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			BMFont v;
			checkType(l,2,out v);
			self.bmFont=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texWidth(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.texWidth);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_texWidth(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.texWidth=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texHeight(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.texHeight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_texHeight(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.texHeight=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasSymbols(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.hasSymbols);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_symbols(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.symbols);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_atlas(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.atlas);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_atlas(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			UIAtlas v;
			checkType(l,2,out v);
			self.atlas=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.material);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			UnityEngine.Material v;
			checkType(l,2,out v);
			self.material=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_premultipliedAlphaShader(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.premultipliedAlphaShader);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packedFontShader(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.packedFontShader);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.texture);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvRect(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.uvRect);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvRect(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			UnityEngine.Rect v;
			checkType(l,2,out v);
			self.uvRect=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spriteName(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.spriteName);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spriteName(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.spriteName=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.isValid);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultSize(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.defaultSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultSize(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.defaultSize=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sprite(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.sprite);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_replacement(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.replacement);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_replacement(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			UIFont v;
			checkType(l,2,out v);
			self.replacement=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDynamic(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.isDynamic);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicFont(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushValue(l,self.dynamicFont);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dynamicFont(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			UnityEngine.Font v;
			checkType(l,2,out v);
			self.dynamicFont=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicFontStyle(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			pushEnum(l,(int)self.dynamicFontStyle);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dynamicFontStyle(IntPtr l) {
		try {
			UIFont self=(UIFont)checkSelf(l);
			UnityEngine.FontStyle v;
			checkEnum(l,2,out v);
			self.dynamicFontStyle=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIFont");
		addMember(l,MarkAsChanged);
		addMember(l,UpdateUVRect);
		addMember(l,MatchSymbol);
		addMember(l,AddSymbol);
		addMember(l,RemoveSymbol);
		addMember(l,RenameSymbol);
		addMember(l,UsesSprite);
		addMember(l,CheckIfRelated_s);
		addMember(l,"bmFont",get_bmFont,set_bmFont,true);
		addMember(l,"texWidth",get_texWidth,set_texWidth,true);
		addMember(l,"texHeight",get_texHeight,set_texHeight,true);
		addMember(l,"hasSymbols",get_hasSymbols,null,true);
		addMember(l,"symbols",get_symbols,null,true);
		addMember(l,"atlas",get_atlas,set_atlas,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"premultipliedAlphaShader",get_premultipliedAlphaShader,null,true);
		addMember(l,"packedFontShader",get_packedFontShader,null,true);
		addMember(l,"texture",get_texture,null,true);
		addMember(l,"uvRect",get_uvRect,set_uvRect,true);
		addMember(l,"spriteName",get_spriteName,set_spriteName,true);
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"defaultSize",get_defaultSize,set_defaultSize,true);
		addMember(l,"sprite",get_sprite,null,true);
		addMember(l,"replacement",get_replacement,set_replacement,true);
		addMember(l,"isDynamic",get_isDynamic,null,true);
		addMember(l,"dynamicFont",get_dynamicFont,set_dynamicFont,true);
		addMember(l,"dynamicFontStyle",get_dynamicFontStyle,set_dynamicFontStyle,true);
		createTypeMetatable(l,null, typeof(UIFont),typeof(UnityEngine.MonoBehaviour));
	}
}
