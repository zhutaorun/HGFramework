#if UNITY_WP8 && !UNITY_EDITOR
using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class UniWebViewPlugin {

    private class InterfaceCallback : UniWebViewWP.Interface.ICallback
    {
        public void LoadStarted(string name, string url)
        {
            UniWebViewEventProcessor.instance.QueueEvent(() =>
            {
                GameObject webviewGO = GameObject.Find(name) as GameObject;
                if (webviewGO != null) {
                    webviewGO.SendMessage("LoadBegin", url);
                }
            });
        }

        public void LoadFinished(string name, string url)
        {
            UniWebViewEventProcessor.instance.QueueEvent(() =>
            {
                GameObject webviewGo = GameObject.Find(name) as GameObject;
                if (webviewGo != null) {
                    webviewGo.SendMessage("LoadComplete", "");
                }
            });
        }

        public void LoadError(string name, string error)
        {
            UniWebViewEventProcessor.instance.QueueEvent(() =>
            {
                GameObject webviewGo = GameObject.Find(name) as GameObject;
                if (webviewGo != null)
                {
                    webviewGo.SendMessage("LoadComplete", error);
                }
            });
        }

        public void ScriptFinished(string name, string result)
        {
            UniWebViewEventProcessor.instance.QueueEvent(() =>
            {
                GameObject webviewGo = GameObject.Find(name) as GameObject;
                if (webviewGo != null)
                {
                    webviewGo.SendMessage("EvalJavaScriptFinished", result);
                }
            });
        }

        public void ReceivedMessage(string name, string message)
        {
            UniWebViewEventProcessor.instance.QueueEvent(() =>
            {
                GameObject webviewGo = GameObject.Find(name) as GameObject;
                if (webviewGo != null)
                {
                    webviewGo.SendMessage("ReceivedMessage", message);
                }
            });
        }

        public void BackKeyPressed(string name)
        {
            UniWebViewEventProcessor.instance.QueueEvent(() =>
            {
                GameObject webviewGo = GameObject.Find(name) as GameObject;
                if (webviewGo != null)
                {
                    webviewGo.SendMessage("WebViewKeyDown", "4"); //Back key code for Android is 4. For compatibility.
                }
            });
        }

        public void WebViewDone(string name)
        {
            UniWebViewEventProcessor.instance.QueueEvent(() =>
            {
                GameObject webviewGo = GameObject.Find(name) as GameObject;
                if (webviewGo != null)
                {
                    webviewGo.SendMessage("WebViewDone", "");
                }
            });
        }
    }

    private static void Setup()
    {
        if (UniWebViewWP.Interface.callBack == null)
        {
            UniWebViewEventProcessor.instance.QueueEvent(() =>
            {

            });

            UniWebViewWP.Interface.callBack = new InterfaceCallback();
        }
    }

	public static void Init(string name, int top, int left, int bottom, int right) {
		Debug.Log("Unity Init");
		if (Application.platform == RuntimePlatform.WP8Player) 
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewInit(name, top, left, bottom, right);
		}
	}

	public static void ChangeSize(string name, int top, int left, int bottom, int right) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewChangeSize(name, top, left, bottom, right);
        }
	}

	public static void Load(string name, string url) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewLoad(name, url);
        }
	}

	public static void LoadHTMLString(string name, string htmlString, string baseUrl) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewLoadHTMLString(name, htmlString, baseUrl);
        }
	}

	public static void Reload(string name) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewReload(name);
        }
	}

	public static void Stop(string name) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewStop(name);
        }
	}

	public static void EvaluatingJavaScript(string name, string javaScript) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewEvaluatingJavaScript(name, javaScript);
        }
	}

	public static void AddJavaScript(string name, string javaScript) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewAddJavaScript(name, javaScript);
        }
	}

	public static void Show(string name) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewShow(name);
        }
	}

	public static void Dismiss(string name) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
             Setup();
            UniWebViewWP.Interface._UniWebViewDismiss(name);
        }
	}

	public static void CleanCache(string name) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewCleanCache(name);
        }
	}

	public static void CleanCookie(string name, string key) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewCleanCookie(name);
        }
	}

	public static void Destroy(string name) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewDestroy(name);
        }
	}

	public static void SetSpinnerShowWhenLoading(string name, bool show) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewSetSpinnerShowWhenLoading(name, show);
        }
	}

	public static void SetSpinnerText(string name, string text) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewSetSpinnerText(name, text);
        }
	}

	public static void TransparentBackground(string name, bool transparent) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewTransparentBackground(name, transparent);
        }
	}

	public static void GoBack(string name) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Debug.Log("Calling go back of native");
            Setup();
            UniWebViewWP.Interface._UniWebViewGoBack(name);
        }
	}

	public static void GoForward(string name) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewGoForward(name);
        }
	}

	public static string GetCurrentUrl(string name) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            return UniWebViewWP.Interface._UniWebViewGetCurrentUrl(name);
        }
		return "";
	}

	public static void SetBackButtonEnable(string name, bool enable) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewSetBackButtonEnable(name, enable);
        }
	}

	public static void SetBounces(string name, bool enable) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            //Setup();
            //UniWebViewWP.Interface._UniWebViewSetBounces(name, enable);
            Debug.Log("SetBounces is not implemented in WP8. You cannot control the zoom in native way. Please use viewport tag in your html header.");
        }
	}

	public static void SetZoomEnable(string name, bool enable) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            //Setup();
            //UniWebViewWP.Interface._UniWebViewSetZoomEnable(name, enable);
            Debug.Log("SetZoomEnable is not implemented in WP8. You cannot control the zoom in native way. Please use viewport tag in your html header.");
        }
	}

	public static void AddUrlScheme(string name, string scheme) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewAddUrlScheme(name, scheme);
        }
	}
	
	public static void RemoveUrlScheme(string name, string scheme) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewRemoveUrlScheme(name, scheme);
        }
	}

	public static void SetUseWideViewPort(string name, bool use) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            //Setup();
            //UniWebViewWP.Interface._UniWebViewUseWideViewPort(name, use);
            Debug.Log("SetUseWideViewPort is not implemented in WP8. viewport tag support is always on for WP8.");
        }
	}

	public static void SetUserAgent(string userAgent) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            UniWebViewWP.Interface._UniWebViewSetUserAgent(userAgent);
        }
	}

	public static string GetUserAgent(string name) {
        if (Application.platform == RuntimePlatform.WP8Player)
        {
            Setup();
            return UniWebViewWP.Interface._UniWebViewGetUserAgent(name);
        }
		return "";
	}


    public static int GetId(string a)
    {
        return 0;
    }

    public static void InputEvent(string name, int x, int y, float deltaY,
                             bool buttonDown, bool buttonPress, bool buttonRelease,
                             bool keyPress, short keyCode, string keyChars, int textureId)
    {
      
    }
}
#endif