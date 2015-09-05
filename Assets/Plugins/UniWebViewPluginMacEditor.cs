#if UNITY_EDITOR
using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class UniWebViewPlugin {
	private static bool _connected;

	public delegate void UnityCallbackDelegate(IntPtr objectName, IntPtr methodName, IntPtr parameter);

	[DllImport("UniWebView")]
	private static extern void _ConnetCallback([MarshalAs(UnmanagedType.FunctionPtr)]UnityCallbackDelegate callbackMethod);

	[DllImport("UniWebView")]
	private static extern void _UniWebViewInit(string name, int top, int left, int bottom, int right, int screenWidth, int screenHeight);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewChangeSize(string name, int top, int left, int bottom, int right, int screenWidth, int screenHeight);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewLoad(string name, string url);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewReload(string name);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewStop(string name);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewShow(string name);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewDismiss(string name);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewEvaluatingJavaScript(string name, string javascript, bool callback);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewCleanCache(string name);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewCleanCookie(string name, string key);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewDestroy(string name);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewTransparentBackground(string name, bool transparent);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewSetSpinnerShowWhenLoading(string name, bool show);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewSetSpinnerText(string name, string text);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewGoBack(string name);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewGoForward(string name);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewLoadHTMLString(string name, string htmlString, string baseUrl);
	[DllImport("UniWebView")]
	private static extern string _UniWebViewGetCurrentUrl(string name);
	[DllImport("UniWebView")]
	private static extern string _UniWebViewAddUrlScheme(string name, string scheme);
	[DllImport("UniWebView")]
	private static extern string _UniWebViewRemoveUrlScheme(string name, string scheme);

	[DllImport("UniWebView")]
	private static extern void _UniWebViewInputEvent(string name, int x, int y, float deltaY, 
	                                                 bool buttonDown, bool buttonPress, bool buttonRelease,
	                                                 bool keyPress, short keyCode, string keyChars, int textureId);
	[DllImport("UniWebView")]
	private static extern int _UniWebViewGetId(string name);
	[DllImport("UniWebView")]
	private static extern void _UniWebViewSetUserAgent(string userAgent);
	[DllImport("UniWebView")]
	private static extern string _UniWebViewGetUserAgent(string name);


	public static void Init(string name, int top, int left, int bottom, int right) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			if (!_connected) {
				ConnectNativeBundle();
			}
			_UniWebViewInit(name, top, left, bottom, right, Screen.width, Screen.height);
		} else {
			Debug.LogWarning("Windows Editor is not supported yet in UniWebView. Please build it to devices or use a Mac Editor.");
		}
	}

	public static void ChangeSize(string name, int top, int left, int bottom, int right) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewChangeSize(name, top, left, bottom, right, Screen.width, Screen.height);
		}
	}

	public static void Load(string name, string url) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewLoad(name, url);
		}
	}

	public static void LoadHTMLString(string name, string htmlString, string baseUrl) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewLoadHTMLString(name,htmlString,baseUrl);
		}
	}

	
	public static void Reload(string name) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewReload(name);
		}
	}

	public static void Stop(string name) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewStop(name);
		}
	}

	public static void Show(string name) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewShow(name);
		}
	}

	public static void EvaluatingJavaScript(string name, string javaScript, bool callback = true) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewEvaluatingJavaScript(name, javaScript, callback);
		}
	}

	public static void AddJavaScript(string name, string javaScript) {
		EvaluatingJavaScript(name, javaScript, false);
	}

	public static void Dismiss(string name) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewDismiss(name);
		}
	}

	public static void CleanCache(string name) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewCleanCache(name);
		}
	}

	public static void CleanCookie(string name, string key) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewCleanCookie(name, key);
		}
	}

	public static void Destroy(string name) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewDestroy(name);
		}
	}

	public static void TransparentBackground(string name, bool transparent) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewTransparentBackground(name, transparent);
		}
	}

	public static void SetSpinnerShowWhenLoading(string name, bool show) {
		Debug.Log("UniWebViewSetSpinnerShowWhenLoading will do nothing in Editor");
	}
	
	public static void SetSpinnerText(string name, string text) {
		Debug.Log("UniWebViewSetSpinnerText will do nothing in Editor");
	}

	public static void GoBack(string name) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewGoBack(name);
		}
	}

	public static void GoForward(string name) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewGoForward(name);
		}
	}

	public static void InputEvent(string name, int x, int y, float deltaY, 
	                         bool buttonDown, bool buttonPress, bool buttonRelease,
	                         bool keyPress, short keyCode, string keyChars, int textureId) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewInputEvent(name,x,y,deltaY,
			                      buttonDown,buttonPress,buttonRelease,
			                      keyPress,keyCode,keyChars,textureId);
		}
	}

	public static int GetId(string name) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			return _UniWebViewGetId(name);
		}
		return 0;
	}

	public static string GetCurrentUrl(string name) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			return _UniWebViewGetCurrentUrl(name);
		}
		return "";
	}

	private static void ConnectNativeBundle() {
		_ConnetCallback((objectName, methodName, parameter) => {
			string objectNameStr = Marshal.PtrToStringAuto(objectName);
			string methodNameStr = Marshal.PtrToStringAuto(methodName);
			string parameterStr = Marshal.PtrToStringAuto(parameter);

			GameObject foundGO = GameObject.Find(objectNameStr);
			if (foundGO != null) {
				foundGO.SendMessage(methodNameStr, parameterStr);
			}
		});
		_connected = true;
	}

	public static void AddUrlScheme(string name, string scheme) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewAddUrlScheme(name, scheme);
		}
	}

	public static void RemoveUrlScheme(string name, string scheme) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewRemoveUrlScheme(name, scheme);
		}
	}

	public static void SetUserAgent(string userAgent) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			_UniWebViewSetUserAgent(userAgent);
		}
	}
	
	public static string GetUserAgent(string name) {
		if (Application.platform == RuntimePlatform.OSXEditor) {
			return _UniWebViewGetUserAgent(name);
		}
		return "";
	}
}
#endif