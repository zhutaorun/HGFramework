using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPopupList : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UIPopupList o;
			o=new UIPopupList();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			self.Clear();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddItem(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UIPopupList self=(UIPopupList)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.AddItem(a1);
				return 0;
			}
			else if(argc==3){
				UIPopupList self=(UIPopupList)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.AddItem(a1,a2);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveItem(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.RemoveItem(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveItemByData(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			self.RemoveItemByData(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CloseSelf(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			self.CloseSelf();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Show(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			self.Show();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Close_s(IntPtr l) {
		try {
			UIPopupList.Close();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		try {
			pushValue(l,UIPopupList.current);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		try {
			UIPopupList v;
			checkType(l,2,out v);
			UIPopupList.current=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_atlas(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
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
			UIPopupList self=(UIPopupList)checkSelf(l);
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
	static public int get_bitmapFont(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.bitmapFont);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bitmapFont(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			UIFont v;
			checkType(l,2,out v);
			self.bitmapFont=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trueTypeFont(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.trueTypeFont);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_trueTypeFont(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			UnityEngine.Font v;
			checkType(l,2,out v);
			self.trueTypeFont=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontSize(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.fontSize);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontSize(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.fontSize=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fontStyle(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushEnum(l,(int)self.fontStyle);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fontStyle(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			UnityEngine.FontStyle v;
			checkEnum(l,2,out v);
			self.fontStyle=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundSprite(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.backgroundSprite);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundSprite(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.backgroundSprite=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highlightSprite(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.highlightSprite);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highlightSprite(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.highlightSprite=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushEnum(l,(int)self.position);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			UIPopupList.Position v;
			checkEnum(l,2,out v);
			self.position=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushEnum(l,(int)self.alignment);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			NGUIText.Alignment v;
			checkEnum(l,2,out v);
			self.alignment=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_items(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.items);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_items(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			System.Collections.Generic.List<System.String> v;
			checkType(l,2,out v);
			self.items=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_itemData(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.itemData);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_itemData(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			System.Collections.Generic.List<System.Object> v;
			checkType(l,2,out v);
			self.itemData=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padding(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.padding);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padding(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.padding=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textColor(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.textColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textColor(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.textColor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundColor(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.backgroundColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundColor(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.backgroundColor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highlightColor(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.highlightColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highlightColor(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.highlightColor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isAnimated(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.isAnimated);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isAnimated(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isAnimated=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isLocalized(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.isLocalized);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isLocalized(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isLocalized=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_openOn(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushEnum(l,(int)self.openOn);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_openOn(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			UIPopupList.OpenOn v;
			checkEnum(l,2,out v);
			self.openOn=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onChange(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.onChange);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onChange(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onChange=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_source(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.source);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_source(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			UnityEngine.GameObject v;
			checkType(l,2,out v);
			self.source=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ambigiousFont(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.ambigiousFont);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ambigiousFont(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			UnityEngine.Object v;
			checkType(l,2,out v);
			self.ambigiousFont=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOpen(IntPtr l) {
		try {
			pushValue(l,UIPopupList.isOpen);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.value);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.value=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_data(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.data);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isColliderEnabled(IntPtr l) {
		try {
			UIPopupList self=(UIPopupList)checkSelf(l);
			pushValue(l,self.isColliderEnabled);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIPopupList");
		addMember(l,Clear);
		addMember(l,AddItem);
		addMember(l,RemoveItem);
		addMember(l,RemoveItemByData);
		addMember(l,CloseSelf);
		addMember(l,Show);
		addMember(l,Close_s);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"atlas",get_atlas,set_atlas,true);
		addMember(l,"bitmapFont",get_bitmapFont,set_bitmapFont,true);
		addMember(l,"trueTypeFont",get_trueTypeFont,set_trueTypeFont,true);
		addMember(l,"fontSize",get_fontSize,set_fontSize,true);
		addMember(l,"fontStyle",get_fontStyle,set_fontStyle,true);
		addMember(l,"backgroundSprite",get_backgroundSprite,set_backgroundSprite,true);
		addMember(l,"highlightSprite",get_highlightSprite,set_highlightSprite,true);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"alignment",get_alignment,set_alignment,true);
		addMember(l,"items",get_items,set_items,true);
		addMember(l,"itemData",get_itemData,set_itemData,true);
		addMember(l,"padding",get_padding,set_padding,true);
		addMember(l,"textColor",get_textColor,set_textColor,true);
		addMember(l,"backgroundColor",get_backgroundColor,set_backgroundColor,true);
		addMember(l,"highlightColor",get_highlightColor,set_highlightColor,true);
		addMember(l,"isAnimated",get_isAnimated,set_isAnimated,true);
		addMember(l,"isLocalized",get_isLocalized,set_isLocalized,true);
		addMember(l,"openOn",get_openOn,set_openOn,true);
		addMember(l,"onChange",get_onChange,set_onChange,true);
		addMember(l,"source",get_source,set_source,true);
		addMember(l,"ambigiousFont",get_ambigiousFont,set_ambigiousFont,true);
		addMember(l,"isOpen",get_isOpen,null,false);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"data",get_data,null,true);
		addMember(l,"isColliderEnabled",get_isColliderEnabled,null,true);
		createTypeMetatable(l,constructor, typeof(UIPopupList),typeof(UIWidgetContainer));
	}
}
