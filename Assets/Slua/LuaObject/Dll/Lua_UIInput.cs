using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIInput : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Validate(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Validate(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Submit(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			self.Submit();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateLabel(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			self.UpdateLabel();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveFocus(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			self.RemoveFocus();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SaveValue(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			self.SaveValue();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadValue(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			self.LoadValue();
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
			pushValue(l,UIInput.current);
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
			UIInput v;
			checkType(l,2,out v);
			UIInput.current=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selection(IntPtr l) {
		try {
			pushValue(l,UIInput.selection);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selection(IntPtr l) {
		try {
			UIInput v;
			checkType(l,2,out v);
			UIInput.selection=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_label(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.label);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_label(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			UILabel v;
			checkType(l,2,out v);
			self.label=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputType(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushEnum(l,(int)self.inputType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inputType(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			UIInput.InputType v;
			checkEnum(l,2,out v);
			self.inputType=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onReturnKey(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushEnum(l,(int)self.onReturnKey);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onReturnKey(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			UIInput.OnReturnKey v;
			checkEnum(l,2,out v);
			self.onReturnKey=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyboardType(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushEnum(l,(int)self.keyboardType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyboardType(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			UIInput.KeyboardType v;
			checkEnum(l,2,out v);
			self.keyboardType=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hideInput(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.hideInput);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hideInput(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.hideInput=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectAllTextOnFocus(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.selectAllTextOnFocus);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectAllTextOnFocus(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.selectAllTextOnFocus=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_validation(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushEnum(l,(int)self.validation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_validation(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			UIInput.Validation v;
			checkEnum(l,2,out v);
			self.validation=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_characterLimit(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.characterLimit);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_characterLimit(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.characterLimit=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_savedAs(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.savedAs);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_savedAs(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.savedAs=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeTextColor(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.activeTextColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_activeTextColor(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.activeTextColor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_caretColor(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.caretColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_caretColor(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.caretColor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectionColor(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.selectionColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectionColor(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.selectionColor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onSubmit(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.onSubmit);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSubmit(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			System.Collections.Generic.List<EventDelegate> v;
			checkType(l,2,out v);
			self.onSubmit=v;
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
			UIInput self=(UIInput)checkSelf(l);
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
			UIInput self=(UIInput)checkSelf(l);
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
	static public int set_onValidate(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			UIInput.OnValidate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onValidate=v;
			else if(op==1) self.onValidate+=v;
			else if(op==2) self.onValidate-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultText(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.defaultText);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultText(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.defaultText=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputShouldBeHidden(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.inputShouldBeHidden);
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
			UIInput self=(UIInput)checkSelf(l);
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
			UIInput self=(UIInput)checkSelf(l);
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
	static public int get_isSelected(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.isSelected);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isSelected(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isSelected=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cursorPosition(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.cursorPosition);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cursorPosition(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.cursorPosition=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectionStart(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.selectionStart);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectionStart(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.selectionStart=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectionEnd(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.selectionEnd);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectionEnd(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.selectionEnd=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_caret(IntPtr l) {
		try {
			UIInput self=(UIInput)checkSelf(l);
			pushValue(l,self.caret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIInput");
		addMember(l,Validate);
		addMember(l,Submit);
		addMember(l,UpdateLabel);
		addMember(l,RemoveFocus);
		addMember(l,SaveValue);
		addMember(l,LoadValue);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"selection",get_selection,set_selection,false);
		addMember(l,"label",get_label,set_label,true);
		addMember(l,"inputType",get_inputType,set_inputType,true);
		addMember(l,"onReturnKey",get_onReturnKey,set_onReturnKey,true);
		addMember(l,"keyboardType",get_keyboardType,set_keyboardType,true);
		addMember(l,"hideInput",get_hideInput,set_hideInput,true);
		addMember(l,"selectAllTextOnFocus",get_selectAllTextOnFocus,set_selectAllTextOnFocus,true);
		addMember(l,"validation",get_validation,set_validation,true);
		addMember(l,"characterLimit",get_characterLimit,set_characterLimit,true);
		addMember(l,"savedAs",get_savedAs,set_savedAs,true);
		addMember(l,"activeTextColor",get_activeTextColor,set_activeTextColor,true);
		addMember(l,"caretColor",get_caretColor,set_caretColor,true);
		addMember(l,"selectionColor",get_selectionColor,set_selectionColor,true);
		addMember(l,"onSubmit",get_onSubmit,set_onSubmit,true);
		addMember(l,"onChange",get_onChange,set_onChange,true);
		addMember(l,"onValidate",null,set_onValidate,true);
		addMember(l,"defaultText",get_defaultText,set_defaultText,true);
		addMember(l,"inputShouldBeHidden",get_inputShouldBeHidden,null,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"isSelected",get_isSelected,set_isSelected,true);
		addMember(l,"cursorPosition",get_cursorPosition,set_cursorPosition,true);
		addMember(l,"selectionStart",get_selectionStart,set_selectionStart,true);
		addMember(l,"selectionEnd",get_selectionEnd,set_selectionEnd,true);
		addMember(l,"caret",get_caret,null,true);
		createTypeMetatable(l,null, typeof(UIInput),typeof(UnityEngine.MonoBehaviour));
	}
}
