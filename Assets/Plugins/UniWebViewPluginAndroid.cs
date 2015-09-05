#if UNITY_ANDROID && !UNITY_EDITOR
using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class UniWebViewPlugin {
	private static AndroidJavaClass webView;

	public static void Init(string name, int top, int left, int bottom, int right) {
		Debug.Log("Unity Init");
		if (Application.platform == RuntimePlatform.Android) {
			webView = new AndroidJavaClass("com.onevcat.uniwebview.AndroidPlugin");

			webView.CallStatic("_UniWebViewInit", name, top, left, bottom, right);
		}
	}

	public static void ChangeSize(string name, int top, int left, int bottom, int right) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewChangeSize", name, top, left, bottom, right);
		}
	}

	public static void Load(string name, string url) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewLoad", name, url);
		}
	}

	public static void LoadHTMLString(string name, string htmlString, string baseUrl) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewLoadHTMLString", name, htmlString, baseUrl);
		}
	}

	public static void Reload(string name) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewReload", name);
		}
	}

	public static void Stop(string name) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewStop", name);
		}
	}

	public static void EvaluatingJavaScript(string name, string javaScript) {
		if (Application.platform == RuntimePlatform.Android) {
			Debug.Log("calling eval js " + javaScript);
			webView.CallStatic("_UniWebViewEvaluatingJavaScript", name, javaScript);
		}
	}

	public static void AddJavaScript(string name, string javaScript) {
		if (Application.platform == RuntimePlatform.Android) {
			Debug.Log("adding js " + javaScript);
			webView.CallStatic("_UniWebViewAddJavaScript", name, javaScript);
		}
	}

	public static void Show(string name) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewShow", name);
		}
	}

	public static void Dismiss(string name) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewDismiss", name);
		}
	}

	public static void CleanCache(string name) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewCleanCache", name);
		}
	}

	public static void CleanCookie(string name, string key) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewCleanCookie", name, key);
		}
	}

	public static void Destroy(string name) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewDestroy", name);
		}
	}

	public static void SetSpinnerShowWhenLoading(string name, bool show) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewSetSpinnerShowWhenLoading", name, show);
		}
	}

	public static void SetSpinnerText(string name, string text) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewSetSpinnerText", name, text);
		}
	}

	public static void TransparentBackground(string name, bool transparent) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewTransparentBackground", name, transparent);
		}
	}

	public static void GoBack(string name) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewGoBack", name);
		}
	}

	public static void GoForward(string name) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewGoForward", name);
		}
	}

	public static string GetCurrentUrl(string name) {
		if (Application.platform == RuntimePlatform.Android) {
			return webView.CallStatic<string>("_UniWebViewGetCurrentUrl", name);
		}
		return "";
	}

	public static void SetBackButtonEnable(string name, bool enable) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewSetBackButtonEnable", name, enable);
		}
	}

	public static void SetBounces(string name, bool enable) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewSetBounces", name, enable);
		}
	}

	public static void SetZoomEnable(string name, bool enable) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewSetZoomEnable", name, enable);
		}
	}

	public static void AddUrlScheme(string name, string scheme) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewAddUrlScheme", name, scheme);
		}
	}
	
	public static void RemoveUrlScheme(string name, string scheme) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewRemoveUrlScheme", name, scheme);
		}
	}

	public static void SetUseWideViewPort(string name, bool use) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewUseWideViewPort", name, use);
		}
	}

	public static void SetUserAgent(string userAgent) {
		if (Application.platform == RuntimePlatform.Android) {
			webView.CallStatic("_UniWebViewSetUserAgent", userAgent);
		}
	}

	public static string GetUserAgent(string name) {
		if (Application.platform == RuntimePlatform.Android) {
			return webView.CallStatic<string>("_UniWebViewGetUserAgent", name);
		}
		return "";
	}

}
#endif