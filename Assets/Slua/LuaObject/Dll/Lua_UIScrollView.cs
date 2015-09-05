using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIScrollView : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RestrictWithinBounds(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UIScrollView self=(UIScrollView)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=self.RestrictWithinBounds(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UIScrollView self=(UIScrollView)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				var ret=self.RestrictWithinBounds(a1,a2,a3);
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
	static public int DisableSpring(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			self.DisableSpring();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateScrollbars(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UIScrollView self=(UIScrollView)checkSelf(l);
				self.UpdateScrollbars();
				return 0;
			}
			else if(argc==2){
				UIScrollView self=(UIScrollView)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.UpdateScrollbars(a1);
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
	static public int SetDragAmount(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.SetDragAmount(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int InvalidateBounds(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			self.InvalidateBounds();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetPosition(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			self.ResetPosition();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdatePosition(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			self.UpdatePosition();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnScrollBar(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			self.OnScrollBar();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveRelative(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.MoveRelative(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveAbsolute(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.MoveAbsolute(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Press(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Press(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Drag(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			self.Drag();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Scroll(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.Scroll(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPan(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			self.OnPan(a1);
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
			pushValue(l,UIScrollView.list);
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
			BetterList<UIScrollView> v;
			checkType(l,2,out v);
			UIScrollView.list=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_movement(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushEnum(l,(int)self.movement);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_movement(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UIScrollView.Movement v;
			checkEnum(l,2,out v);
			self.movement=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragEffect(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushEnum(l,(int)self.dragEffect);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragEffect(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UIScrollView.DragEffect v;
			checkEnum(l,2,out v);
			self.dragEffect=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_restrictWithinPanel(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.restrictWithinPanel);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_restrictWithinPanel(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.restrictWithinPanel=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disableDragIfFits(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.disableDragIfFits);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disableDragIfFits(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.disableDragIfFits=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_smoothDragStart(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.smoothDragStart);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_smoothDragStart(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.smoothDragStart=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_iOSDragEmulation(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.iOSDragEmulation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_iOSDragEmulation(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.iOSDragEmulation=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollWheelFactor(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.scrollWheelFactor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollWheelFactor(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.scrollWheelFactor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_momentumAmount(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.momentumAmount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_momentumAmount(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.momentumAmount=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dampenStrength(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.dampenStrength);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dampenStrength(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.dampenStrength=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalScrollBar(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.horizontalScrollBar);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalScrollBar(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UIProgressBar v;
			checkType(l,2,out v);
			self.horizontalScrollBar=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalScrollBar(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.verticalScrollBar);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalScrollBar(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UIProgressBar v;
			checkType(l,2,out v);
			self.verticalScrollBar=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showScrollBars(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushEnum(l,(int)self.showScrollBars);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showScrollBars(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UIScrollView.ShowCondition v;
			checkEnum(l,2,out v);
			self.showScrollBars=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_customMovement(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.customMovement);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_customMovement(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.customMovement=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contentPivot(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushEnum(l,(int)self.contentPivot);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_contentPivot(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UIWidget.Pivot v;
			checkEnum(l,2,out v);
			self.contentPivot=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragStarted(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UIScrollView.OnDragNotification v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDragStarted=v;
			else if(op==1) self.onDragStarted+=v;
			else if(op==2) self.onDragStarted-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragFinished(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UIScrollView.OnDragNotification v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDragFinished=v;
			else if(op==1) self.onDragFinished+=v;
			else if(op==2) self.onDragFinished-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onMomentumMove(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UIScrollView.OnDragNotification v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onMomentumMove=v;
			else if(op==1) self.onMomentumMove+=v;
			else if(op==2) self.onMomentumMove-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onStoppedMoving(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UIScrollView.OnDragNotification v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onStoppedMoving=v;
			else if(op==1) self.onStoppedMoving+=v;
			else if(op==2) self.onStoppedMoving-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_centerOnChild(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.centerOnChild);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_centerOnChild(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UICenterOnChild v;
			checkType(l,2,out v);
			self.centerOnChild=v;
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
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.panel);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDragging(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.isDragging);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.bounds);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canMoveHorizontally(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.canMoveHorizontally);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canMoveVertically(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.canMoveVertically);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shouldMoveHorizontally(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.shouldMoveHorizontally);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shouldMoveVertically(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.shouldMoveVertically);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentMomentum(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			pushValue(l,self.currentMomentum);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currentMomentum(IntPtr l) {
		try {
			UIScrollView self=(UIScrollView)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.currentMomentum=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIScrollView");
		addMember(l,RestrictWithinBounds);
		addMember(l,DisableSpring);
		addMember(l,UpdateScrollbars);
		addMember(l,SetDragAmount);
		addMember(l,InvalidateBounds);
		addMember(l,ResetPosition);
		addMember(l,UpdatePosition);
		addMember(l,OnScrollBar);
		addMember(l,MoveRelative);
		addMember(l,MoveAbsolute);
		addMember(l,Press);
		addMember(l,Drag);
		addMember(l,Scroll);
		addMember(l,OnPan);
		addMember(l,"list",get_list,set_list,false);
		addMember(l,"movement",get_movement,set_movement,true);
		addMember(l,"dragEffect",get_dragEffect,set_dragEffect,true);
		addMember(l,"restrictWithinPanel",get_restrictWithinPanel,set_restrictWithinPanel,true);
		addMember(l,"disableDragIfFits",get_disableDragIfFits,set_disableDragIfFits,true);
		addMember(l,"smoothDragStart",get_smoothDragStart,set_smoothDragStart,true);
		addMember(l,"iOSDragEmulation",get_iOSDragEmulation,set_iOSDragEmulation,true);
		addMember(l,"scrollWheelFactor",get_scrollWheelFactor,set_scrollWheelFactor,true);
		addMember(l,"momentumAmount",get_momentumAmount,set_momentumAmount,true);
		addMember(l,"dampenStrength",get_dampenStrength,set_dampenStrength,true);
		addMember(l,"horizontalScrollBar",get_horizontalScrollBar,set_horizontalScrollBar,true);
		addMember(l,"verticalScrollBar",get_verticalScrollBar,set_verticalScrollBar,true);
		addMember(l,"showScrollBars",get_showScrollBars,set_showScrollBars,true);
		addMember(l,"customMovement",get_customMovement,set_customMovement,true);
		addMember(l,"contentPivot",get_contentPivot,set_contentPivot,true);
		addMember(l,"onDragStarted",null,set_onDragStarted,true);
		addMember(l,"onDragFinished",null,set_onDragFinished,true);
		addMember(l,"onMomentumMove",null,set_onMomentumMove,true);
		addMember(l,"onStoppedMoving",null,set_onStoppedMoving,true);
		addMember(l,"centerOnChild",get_centerOnChild,set_centerOnChild,true);
		addMember(l,"panel",get_panel,null,true);
		addMember(l,"isDragging",get_isDragging,null,true);
		addMember(l,"bounds",get_bounds,null,true);
		addMember(l,"canMoveHorizontally",get_canMoveHorizontally,null,true);
		addMember(l,"canMoveVertically",get_canMoveVertically,null,true);
		addMember(l,"shouldMoveHorizontally",get_shouldMoveHorizontally,null,true);
		addMember(l,"shouldMoveVertically",get_shouldMoveVertically,null,true);
		addMember(l,"currentMomentum",get_currentMomentum,set_currentMomentum,true);
		createTypeMetatable(l,null, typeof(UIScrollView),typeof(UnityEngine.MonoBehaviour));
	}
}
