using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIRect : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateFinalAlpha(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.CalculateFinalAlpha(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Invalidate(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Invalidate(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSides(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			var ret=self.GetSides(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			self.Update();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateAnchors(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			self.UpdateAnchors();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetAnchor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.GameObject))){
				UIRect self=(UIRect)checkSelf(l);
				UnityEngine.GameObject a1;
				checkType(l,2,out a1);
				self.SetAnchor(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Transform))){
				UIRect self=(UIRect)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				self.SetAnchor(a1);
				return 0;
			}
			else if(argc==6){
				UIRect self=(UIRect)checkSelf(l);
				UnityEngine.GameObject a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				self.SetAnchor(a1,a2,a3,a4,a5);
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
	static public int ResetAnchors(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			self.ResetAnchors();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetAndUpdateAnchors(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			self.ResetAndUpdateAnchors();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetRect(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.SetRect(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ParentHasChanged(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			self.ParentHasChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_leftAnchor(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.leftAnchor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_leftAnchor(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			UIRect.AnchorPoint v;
			checkType(l,2,out v);
			self.leftAnchor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rightAnchor(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.rightAnchor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rightAnchor(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			UIRect.AnchorPoint v;
			checkType(l,2,out v);
			self.rightAnchor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bottomAnchor(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.bottomAnchor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bottomAnchor(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			UIRect.AnchorPoint v;
			checkType(l,2,out v);
			self.bottomAnchor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_topAnchor(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.topAnchor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_topAnchor(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			UIRect.AnchorPoint v;
			checkType(l,2,out v);
			self.topAnchor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateAnchors(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushEnum(l,(int)self.updateAnchors);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateAnchors(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			UIRect.AnchorUpdate v;
			checkEnum(l,2,out v);
			self.updateAnchors=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_finalAlpha(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.finalAlpha);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_finalAlpha(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.finalAlpha=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedGameObject(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.cachedGameObject);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedTransform(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.cachedTransform);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchorCamera(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.anchorCamera);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isFullyAnchored(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.isFullyAnchored);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isAnchoredHorizontally(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.isAnchoredHorizontally);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isAnchoredVertically(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.isAnchoredVertically);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canBeAnchored(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.canBeAnchored);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_parent(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.parent);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_root(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.root);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isAnchored(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.isAnchored);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alpha(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
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
			UIRect self=(UIRect)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.alpha=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localCorners(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.localCorners);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldCorners(IntPtr l) {
		try {
			UIRect self=(UIRect)checkSelf(l);
			pushValue(l,self.worldCorners);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIRect");
		addMember(l,CalculateFinalAlpha);
		addMember(l,Invalidate);
		addMember(l,GetSides);
		addMember(l,Update);
		addMember(l,UpdateAnchors);
		addMember(l,SetAnchor);
		addMember(l,ResetAnchors);
		addMember(l,ResetAndUpdateAnchors);
		addMember(l,SetRect);
		addMember(l,ParentHasChanged);
		addMember(l,"leftAnchor",get_leftAnchor,set_leftAnchor,true);
		addMember(l,"rightAnchor",get_rightAnchor,set_rightAnchor,true);
		addMember(l,"bottomAnchor",get_bottomAnchor,set_bottomAnchor,true);
		addMember(l,"topAnchor",get_topAnchor,set_topAnchor,true);
		addMember(l,"updateAnchors",get_updateAnchors,set_updateAnchors,true);
		addMember(l,"finalAlpha",get_finalAlpha,set_finalAlpha,true);
		addMember(l,"cachedGameObject",get_cachedGameObject,null,true);
		addMember(l,"cachedTransform",get_cachedTransform,null,true);
		addMember(l,"anchorCamera",get_anchorCamera,null,true);
		addMember(l,"isFullyAnchored",get_isFullyAnchored,null,true);
		addMember(l,"isAnchoredHorizontally",get_isAnchoredHorizontally,null,true);
		addMember(l,"isAnchoredVertically",get_isAnchoredVertically,null,true);
		addMember(l,"canBeAnchored",get_canBeAnchored,null,true);
		addMember(l,"parent",get_parent,null,true);
		addMember(l,"root",get_root,null,true);
		addMember(l,"isAnchored",get_isAnchored,null,true);
		addMember(l,"alpha",get_alpha,set_alpha,true);
		addMember(l,"localCorners",get_localCorners,null,true);
		addMember(l,"worldCorners",get_worldCorners,null,true);
		createTypeMetatable(l,null, typeof(UIRect),typeof(UnityEngine.MonoBehaviour));
	}
}
