using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPanel : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UIPanel o;
			o=new UIPanel();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSides(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
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
	static public int Invalidate(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
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
	static public int CalculateFinalAlpha(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
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
	static public int SetRect(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
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
	static public int IsVisible(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UIWidget))){
				UIPanel self=(UIPanel)checkSelf(l);
				UIWidget a1;
				checkType(l,2,out a1);
				var ret=self.IsVisible(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector3))){
				UIPanel self=(UIPanel)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				var ret=self.IsVisible(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UIPanel self=(UIPanel)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,4,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,5,out a4);
				var ret=self.IsVisible(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
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
	static public int Affects(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UIWidget a1;
			checkType(l,2,out a1);
			var ret=self.Affects(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RebuildAllDrawCalls(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			self.RebuildAllDrawCalls();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetDirty(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			self.SetDirty();
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
			UIPanel self=(UIPanel)checkSelf(l);
			self.ParentHasChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SortWidgets(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			self.SortWidgets();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindDrawCall(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UIWidget a1;
			checkType(l,2,out a1);
			var ret=self.FindDrawCall(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddWidget(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UIWidget a1;
			checkType(l,2,out a1);
			self.AddWidget(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveWidget(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UIWidget a1;
			checkType(l,2,out a1);
			self.RemoveWidget(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Refresh(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			self.Refresh();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateConstrainOffset(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,3,out a2);
			var ret=self.CalculateConstrainOffset(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConstrainTargetToBounds(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UIPanel self=(UIPanel)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.ConstrainTargetToBounds(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UIPanel self=(UIPanel)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				UnityEngine.Bounds a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				var ret=self.ConstrainTargetToBounds(a1,ref a2,a3);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
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
	static public int GetWindowSize(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			var ret=self.GetWindowSize();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetViewSize(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			var ret=self.GetViewSize();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompareFunc_s(IntPtr l) {
		try {
			UIPanel a1;
			checkType(l,1,out a1);
			UIPanel a2;
			checkType(l,2,out a2);
			var ret=UIPanel.CompareFunc(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Find_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				var ret=UIPanel.Find(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				var ret=UIPanel.Find(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Transform a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				var ret=UIPanel.Find(a1,a2,a3);
				pushValue(l,ret);
				return 1;
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
	static public int get_list(IntPtr l) {
		try {
			pushValue(l,UIPanel.list);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_list(IntPtr l) {
		try {
			System.Collections.Generic.List<UIPanel> v;
			checkType(l,2,out v);
			UIPanel.list=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onGeometryUpdated(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UIPanel.OnGeometryUpdated v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onGeometryUpdated=v;
			else if(op==1) self.onGeometryUpdated+=v;
			else if(op==2) self.onGeometryUpdated-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showInPanelTool(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.showInPanelTool);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showInPanelTool(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.showInPanelTool=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_generateNormals(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.generateNormals);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_generateNormals(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.generateNormals=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_widgetsAreStatic(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.widgetsAreStatic);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_widgetsAreStatic(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.widgetsAreStatic=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cullWhileDragging(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.cullWhileDragging);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cullWhileDragging(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.cullWhileDragging=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alwaysOnScreen(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.alwaysOnScreen);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alwaysOnScreen(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.alwaysOnScreen=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchorOffset(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.anchorOffset);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchorOffset(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.anchorOffset=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_softBorderPadding(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.softBorderPadding);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_softBorderPadding(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.softBorderPadding=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderQueue(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushEnum(l,(int)self.renderQueue);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderQueue(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UIPanel.RenderQueue v;
			checkEnum(l,2,out v);
			self.renderQueue=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startingRenderQueue(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.startingRenderQueue);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startingRenderQueue(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.startingRenderQueue=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_widgets(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.widgets);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_widgets(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			System.Collections.Generic.List<UIWidget> v;
			checkType(l,2,out v);
			self.widgets=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drawCalls(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.drawCalls);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_drawCalls(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			System.Collections.Generic.List<UIDrawCall> v;
			checkType(l,2,out v);
			self.drawCalls=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldToLocal(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.worldToLocal);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldToLocal(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UnityEngine.Matrix4x4 v;
			checkType(l,2,out v);
			self.worldToLocal=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drawCallClipRange(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.drawCallClipRange);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_drawCallClipRange(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UnityEngine.Vector4 v;
			checkType(l,2,out v);
			self.drawCallClipRange=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onClipMove(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UIPanel.OnClippingMoved v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onClipMove=v;
			else if(op==1) self.onClipMove+=v;
			else if(op==2) self.onClipMove-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nextUnusedDepth(IntPtr l) {
		try {
			pushValue(l,UIPanel.nextUnusedDepth);
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
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.canBeAnchored);
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
			UIPanel self=(UIPanel)checkSelf(l);
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
			UIPanel self=(UIPanel)checkSelf(l);
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
	static public int get_depth(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.depth);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depth(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.depth=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingOrder(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.sortingOrder);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingOrder(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.sortingOrder=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.width);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.height);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_halfPixelOffset(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.halfPixelOffset);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_usedForUI(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.usedForUI);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drawCallOffset(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.drawCallOffset);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipping(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushEnum(l,(int)self.clipping);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipping(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UIDrawCall.Clipping v;
			checkEnum(l,2,out v);
			self.clipping=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_parentPanel(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.parentPanel);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipCount(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.clipCount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasClipping(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.hasClipping);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasCumulativeClipping(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.hasCumulativeClipping);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipOffset(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.clipOffset);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipOffset(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.clipOffset=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipTexture(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.clipTexture);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipTexture(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UnityEngine.Texture2D v;
			checkType(l,2,out v);
			self.clipTexture=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baseClipRegion(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.baseClipRegion);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_baseClipRegion(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UnityEngine.Vector4 v;
			checkType(l,2,out v);
			self.baseClipRegion=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_finalClipRegion(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.finalClipRegion);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipSoftness(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.clipSoftness);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipSoftness(IntPtr l) {
		try {
			UIPanel self=(UIPanel)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.clipSoftness=v;
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
			UIPanel self=(UIPanel)checkSelf(l);
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
			UIPanel self=(UIPanel)checkSelf(l);
			pushValue(l,self.worldCorners);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIPanel");
		addMember(l,GetSides);
		addMember(l,Invalidate);
		addMember(l,CalculateFinalAlpha);
		addMember(l,SetRect);
		addMember(l,IsVisible);
		addMember(l,Affects);
		addMember(l,RebuildAllDrawCalls);
		addMember(l,SetDirty);
		addMember(l,ParentHasChanged);
		addMember(l,SortWidgets);
		addMember(l,FindDrawCall);
		addMember(l,AddWidget);
		addMember(l,RemoveWidget);
		addMember(l,Refresh);
		addMember(l,CalculateConstrainOffset);
		addMember(l,ConstrainTargetToBounds);
		addMember(l,GetWindowSize);
		addMember(l,GetViewSize);
		addMember(l,CompareFunc_s);
		addMember(l,Find_s);
		addMember(l,"list",get_list,set_list,false);
		addMember(l,"onGeometryUpdated",null,set_onGeometryUpdated,true);
		addMember(l,"showInPanelTool",get_showInPanelTool,set_showInPanelTool,true);
		addMember(l,"generateNormals",get_generateNormals,set_generateNormals,true);
		addMember(l,"widgetsAreStatic",get_widgetsAreStatic,set_widgetsAreStatic,true);
		addMember(l,"cullWhileDragging",get_cullWhileDragging,set_cullWhileDragging,true);
		addMember(l,"alwaysOnScreen",get_alwaysOnScreen,set_alwaysOnScreen,true);
		addMember(l,"anchorOffset",get_anchorOffset,set_anchorOffset,true);
		addMember(l,"softBorderPadding",get_softBorderPadding,set_softBorderPadding,true);
		addMember(l,"renderQueue",get_renderQueue,set_renderQueue,true);
		addMember(l,"startingRenderQueue",get_startingRenderQueue,set_startingRenderQueue,true);
		addMember(l,"widgets",get_widgets,set_widgets,true);
		addMember(l,"drawCalls",get_drawCalls,set_drawCalls,true);
		addMember(l,"worldToLocal",get_worldToLocal,set_worldToLocal,true);
		addMember(l,"drawCallClipRange",get_drawCallClipRange,set_drawCallClipRange,true);
		addMember(l,"onClipMove",null,set_onClipMove,true);
		addMember(l,"nextUnusedDepth",get_nextUnusedDepth,null,false);
		addMember(l,"canBeAnchored",get_canBeAnchored,null,true);
		addMember(l,"alpha",get_alpha,set_alpha,true);
		addMember(l,"depth",get_depth,set_depth,true);
		addMember(l,"sortingOrder",get_sortingOrder,set_sortingOrder,true);
		addMember(l,"width",get_width,null,true);
		addMember(l,"height",get_height,null,true);
		addMember(l,"halfPixelOffset",get_halfPixelOffset,null,true);
		addMember(l,"usedForUI",get_usedForUI,null,true);
		addMember(l,"drawCallOffset",get_drawCallOffset,null,true);
		addMember(l,"clipping",get_clipping,set_clipping,true);
		addMember(l,"parentPanel",get_parentPanel,null,true);
		addMember(l,"clipCount",get_clipCount,null,true);
		addMember(l,"hasClipping",get_hasClipping,null,true);
		addMember(l,"hasCumulativeClipping",get_hasCumulativeClipping,null,true);
		addMember(l,"clipOffset",get_clipOffset,set_clipOffset,true);
		addMember(l,"clipTexture",get_clipTexture,set_clipTexture,true);
		addMember(l,"baseClipRegion",get_baseClipRegion,set_baseClipRegion,true);
		addMember(l,"finalClipRegion",get_finalClipRegion,null,true);
		addMember(l,"clipSoftness",get_clipSoftness,set_clipSoftness,true);
		addMember(l,"localCorners",get_localCorners,null,true);
		addMember(l,"worldCorners",get_worldCorners,null,true);
		createTypeMetatable(l,constructor, typeof(UIPanel),typeof(UIRect));
	}
}
