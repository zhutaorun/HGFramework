#if UNITY_IOS && !UNITY_EDITOR
using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class UniWebViewPlugin {

	[DllImport("__Internal")]
	private static extern void _UniWebViewInit(string name, int top, int left, int bottom, int right);
	[DllImport("__Internal")]
	private static extern void _UniWebViewChangeSize(string name, int top, int left, int bottom, int right);
	[DllImport("__Internal")]
	private static extern void _UniWebViewLoad(string name, string url);
	[DllImport("__Internal")]
	private static extern void _UniWebViewLoadHTMLString(string name, string htmlString, string baseUrl);
	[DllImport("__Internal")]
	private static extern void _UniWebViewReload(string name);
	[DllImport("__Internal")]
	private static extern void _UniWebViewStop(string name);
	[DllImport("__Internal")]
	private static extern void _UniWebViewShow(string name);
	[DllImport("__Internal")]
	private static extern void _UniWebViewEvaluatingJavaScript(string name, string javascript, bool callback);
	[DllImport("__Internal")]
	private static extern void _UniWebViewDismiss(string name);
	[DllImport("__Internal")]
	private static extern void _UniWebViewCleanCache(string name);
	[DllImport("__Internal")]
	private static extern void _UniWebViewCleanCookie(string name, string key);
	[DllImport("__Internal")]
	private static extern void _UniWebViewDestroy(string name);
	[DllImport("__Internal")]
	private static extern void _UniWebViewTransparentBackground(string name, bool transparent);
	[DllImport("__Internal")]
	private static extern void _UniWebViewSetSpinnerShowWhenLoading(string name, bool show);
	[DllImport("__Internal")]
	private static extern void _UniWebViewSetSpinnerText(string name, string text);
	[DllImport("__Internal")]
	private static extern void _UniWebViewShowToolBar(string name, bool animate);
	[DllImport("__Internal")]
	private static extern void _UniWebViewHideToolBar(string name, bool animate);
	[DllImport("__Internal")]
	private static extern void _UniWebViewGoBack(string name);
	[DllImport("__Internal")]
	private static extern void _UniWebViewGoForward(string name);
	[DllImport("__Internal")]
	private static extern string _UniWebViewGetCurrentUrl(string name);
	[DllImport("__Internal")]
	private static extern void _UniWebViewSetBounces(string name, bool bounces);
	[DllImport("__Internal")]
	private static extern void _UniWebViewSetZoomEnable(string name, bool enable);
	[DllImport("__Internal")]
	private static extern void _UniWebViewAddUrlScheme(string name, string scheme);
	[DllImport("__Internal")]
	private static extern void _UniWebViewRemoveUrlScheme(string name, string scheme);
	[DllImport("__Internal")]
	private static extern int _UniWebViewScreenHeight();
	[DllImport("__Internal")]
	private static extern int _UniWebViewScreenWidth();
	[DllImport("__Internal")]
	private static extern void _UniWebViewSetUserAgent(string userAgent);
	[DllImport("__Internal")]
	private static extern string _UniWebViewGetUserAgent(string name);

	public static void Init(string name, int top, int left, int bottom, int right) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewInit(name, top, left, bottom, right);
		}
	}

	public static void ChangeSize(string name, int top, int left, int bottom, int right) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewChangeSize(name, top, left, bottom, right);
		}
	}

	public static void Load(string name, string url) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewLoad(name, url);
		}
	}

	public static void LoadHTMLString(string name, string htmlString, string baseUrl) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewLoadHTMLString(name,htmlString,baseUrl);
		}
	}

	public static void Reload(string name) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewReload(name);
		}
	}

	public static void Stop(string name) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewStop(name);
		}
	}

	public static void Show(string name) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewShow(name);
		}
	}

	public static void EvaluatingJavaScript(string name, string javaScript, bool callback = true) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewEvaluatingJavaScript(name, javaScript, callback);
		}
	}

	public static void AddJavaScript(string name, string javaScript) {
		EvaluatingJavaScript(name, javaScript, false);
	}

	public static void Dismiss(string name) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewDismiss(name);
		}
	}

	public static void CleanCache(string name) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewCleanCache(name);
		}
	}

	public static void CleanCookie(string name, string key) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewCleanCookie(name, key);
		}
	}

	public static void Destroy(string name) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewDestroy(name);
		}
	}

	public static void TransparentBackground(string name, bool transparent) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewTransparentBackground(name, transparent);
		}
	}

	public static void SetSpinnerShowWhenLoading(string name, bool show) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewSetSpinnerShowWhenLoading(name, show);
		}
	}

	public static void SetSpinnerText(string name, string text) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewSetSpinnerText(name, text);
		}
	}

	public static void ShowToolBar(string name, bool animate) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewShowToolBar(name, animate);
		}
	}

	public static void HideToolBar(string name, bool animate) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewHideToolBar(name, animate);
		}
	}

	public static void GoBack(string name) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewGoBack(name);
		}
	}

	public static void GoForward(string name) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewGoForward(name);
		}
	}

	public static string GetCurrentUrl(string name) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			return _UniWebViewGetCurrentUrl(name);
		}
		return "";
	}

	public static void SetBounces(string name, bool bounces) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewSetBounces(name, bounces);
		}
	}

	public static void SetZoomEnable(string name, bool enable) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewSetZoomEnable(name, enable);
		}
	}

	public static void AddUrlScheme(string name, string scheme) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewAddUrlScheme(name, scheme);
		}
	}

	public static void RemoveUrlScheme(string name, string scheme) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewRemoveUrlScheme(name, scheme);
		}
	}

	public static int ScreenHeight() {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			return _UniWebViewScreenHeight();
		}
		return 0;
	}

	public static int ScreenWidth() {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			return _UniWebViewScreenWidth();
		}
		return 0;
	}

	public static void SetUserAgent(string userAgent) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			_UniWebViewSetUserAgent(userAgent);
		}
	}

	public static string GetUserAgent(string name) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			return _UniWebViewGetUserAgent(name);
		}
		return "";
	}
}
#endif