using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDrawCall : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateGeometry(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.UpdateGeometry(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Create_s(IntPtr l) {
		try {
			UIPanel a1;
			checkType(l,1,out a1);
			UnityEngine.Material a2;
			checkType(l,2,out a2);
			UnityEngine.Texture a3;
			checkType(l,3,out a3);
			UnityEngine.Shader a4;
			checkType(l,4,out a4);
			var ret=UIDrawCall.Create(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearAll_s(IntPtr l) {
		try {
			UIDrawCall.ClearAll();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReleaseAll_s(IntPtr l) {
		try {
			UIDrawCall.ReleaseAll();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReleaseInactive_s(IntPtr l) {
		try {
			UIDrawCall.ReleaseInactive();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Count_s(IntPtr l) {
		try {
			UIPanel a1;
			checkType(l,1,out a1);
			var ret=UIDrawCall.Count(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Destroy_s(IntPtr l) {
		try {
			UIDrawCall a1;
			checkType(l,1,out a1);
			UIDrawCall.Destroy(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_widgetCount(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.widgetCount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_widgetCount(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.widgetCount=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depthStart(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.depthStart);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depthStart(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.depthStart=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depthEnd(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.depthEnd);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depthEnd(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.depthEnd=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_manager(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.manager);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_manager(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			UIPanel v;
			checkType(l,2,out v);
			self.manager=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_panel(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.panel);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_panel(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			UIPanel v;
			checkType(l,2,out v);
			self.panel=v;
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
			UIDrawCall self=(UIDrawCall)checkSelf(l);
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
			UIDrawCall self=(UIDrawCall)checkSelf(l);
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
	static public int get_alwaysOnScreen(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
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
			UIDrawCall self=(UIDrawCall)checkSelf(l);
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
	static public int get_verts(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.verts);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verts(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			BetterList<UnityEngine.Vector3> v;
			checkType(l,2,out v);
			self.verts=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_norms(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.norms);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_norms(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			BetterList<UnityEngine.Vector3> v;
			checkType(l,2,out v);
			self.norms=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tans(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.tans);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tans(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			BetterList<UnityEngine.Vector4> v;
			checkType(l,2,out v);
			self.tans=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvs(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.uvs);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvs(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			BetterList<UnityEngine.Vector2> v;
			checkType(l,2,out v);
			self.uvs=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cols(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.cols);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cols(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			BetterList<UnityEngine.Color32> v;
			checkType(l,2,out v);
			self.cols=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDirty(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.isDirty);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isDirty(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isDirty=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onRender(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			UIDrawCall.OnRenderCallback v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onRender=v;
			else if(op==1) self.onRender+=v;
			else if(op==2) self.onRender-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeList(IntPtr l) {
		try {
			pushValue(l,UIDrawCall.activeList);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inactiveList(IntPtr l) {
		try {
			pushValue(l,UIDrawCall.inactiveList);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderQueue(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.renderQueue);
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
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.renderQueue=v;
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
			UIDrawCall self=(UIDrawCall)checkSelf(l);
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
			UIDrawCall self=(UIDrawCall)checkSelf(l);
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
	static public int get_finalRenderQueue(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.finalRenderQueue);
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
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.cachedTransform);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baseMaterial(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.baseMaterial);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_baseMaterial(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			UnityEngine.Material v;
			checkType(l,2,out v);
			self.baseMaterial=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicMaterial(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.dynamicMaterial);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.mainTexture);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mainTexture(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			UnityEngine.Texture v;
			checkType(l,2,out v);
			self.mainTexture=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shader(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.shader);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shader(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			UnityEngine.Shader v;
			checkType(l,2,out v);
			self.shader=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_triangles(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.triangles);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isClipped(IntPtr l) {
		try {
			UIDrawCall self=(UIDrawCall)checkSelf(l);
			pushValue(l,self.isClipped);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDrawCall");
		addMember(l,UpdateGeometry);
		addMember(l,Create_s);
		addMember(l,ClearAll_s);
		addMember(l,ReleaseAll_s);
		addMember(l,ReleaseInactive_s);
		addMember(l,Count_s);
		addMember(l,Destroy_s);
		addMember(l,"widgetCount",get_widgetCount,set_widgetCount,true);
		addMember(l,"depthStart",get_depthStart,set_depthStart,true);
		addMember(l,"depthEnd",get_depthEnd,set_depthEnd,true);
		addMember(l,"manager",get_manager,set_manager,true);
		addMember(l,"panel",get_panel,set_panel,true);
		addMember(l,"clipTexture",get_clipTexture,set_clipTexture,true);
		addMember(l,"alwaysOnScreen",get_alwaysOnScreen,set_alwaysOnScreen,true);
		addMember(l,"verts",get_verts,set_verts,true);
		addMember(l,"norms",get_norms,set_norms,true);
		addMember(l,"tans",get_tans,set_tans,true);
		addMember(l,"uvs",get_uvs,set_uvs,true);
		addMember(l,"cols",get_cols,set_cols,true);
		addMember(l,"isDirty",get_isDirty,set_isDirty,true);
		addMember(l,"onRender",null,set_onRender,true);
		addMember(l,"activeList",get_activeList,null,false);
		addMember(l,"inactiveList",get_inactiveList,null,false);
		addMember(l,"renderQueue",get_renderQueue,set_renderQueue,true);
		addMember(l,"sortingOrder",get_sortingOrder,set_sortingOrder,true);
		addMember(l,"finalRenderQueue",get_finalRenderQueue,null,true);
		addMember(l,"cachedTransform",get_cachedTransform,null,true);
		addMember(l,"baseMaterial",get_baseMaterial,set_baseMaterial,true);
		addMember(l,"dynamicMaterial",get_dynamicMaterial,null,true);
		addMember(l,"mainTexture",get_mainTexture,set_mainTexture,true);
		addMember(l,"shader",get_shader,set_shader,true);
		addMember(l,"triangles",get_triangles,null,true);
		addMember(l,"isClipped",get_isClipped,null,true);
		createTypeMetatable(l,null, typeof(UIDrawCall),typeof(UnityEngine.MonoBehaviour));
	}
}
