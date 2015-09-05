using System;
using System.Collections;
using UnityEngine;

namespace cn.sharesdk.unity3d {
#if UNITY_ANDROID
	public class AndroidUtils {
		private static AndroidUtils instance;
		private AndroidJavaClass ssdk;
		private AuthResultEvent authHandler;
		private GetUserInfoResultEvent showUserHandler;
		private ShareResultEvent shareHandler;

		private AndroidUtils() {
			ssdk = new AndroidJavaClass("cn.sharesdk.unity3d.ShareSDKUtils");
		}

		/// <summary>
		/// Gets the instance of AndroidUtils.
		/// </summary>
		/// <returns>The instance.</returns>
		/// <param name="gameObject">Game object.</param>
		public static AndroidUtils getInstance() {
			if (instance == null) {
				instance = new AndroidUtils();
			}
			return instance;
		}

		/// <summary>
		/// Sets the game object.
		/// </summary>
		/// <param name="gameObject">Game object.</param>
		public void setGameObject(string gameObject) {
			ssdk.CallStatic("setGameObject", gameObject, "_callback");
		}

		/// <summary>
		/// Inits the SDK.
		/// </summary>
		public void initSDK() {
			initSDK(null);
		}

		/// <summary>
		/// Inits the SDK.
		/// </summary>
		/// <param name="appKey">Appkey.</param>
		public void initSDK(string appKey) {
			ssdk.CallStatic("initSDK", appKey);
		}

		/// <summary>
		/// Stops the SDK.
		/// </summary>
		public void stopSDK() {
			ssdk.CallStatic("stopSDK");
		}

		/// <summary>
		/// Sets the platform config.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="configs">Configs.</param>
		public void setPlatformConfig(int platform, Hashtable configs) {
			String json = MiniJSON.jsonEncode(configs);
			ssdk.CallStatic("setPlatformConfig", platform, json);
		}

		/// <summary>
		/// Authorize the specified platform.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="resultHandler">Result handler.</param>
		public void authorize(int platform, AuthResultEvent resultHandler) {
			authHandler = resultHandler;
			ssdk.CallStatic("authorize", platform);
		}

		/// <summary>
		/// Removes the account of the specified platform.
		/// </summary>
		/// <param name="platform">Platform.</param>
		public void removeAccount(int platform) {
			ssdk.CallStatic("removeAccount", platform);
		}

		/// <summary>
		/// Determine weather the account of the specified platform is valid.
		/// </summary>
		/// <returns><c>true</c>, if valid was ised, <c>false</c> otherwise.</returns>
		/// <param name="platform">Platform.</param>
		public bool isValid(int platform) {
			return ssdk.CallStatic<bool>("isValid", platform);
		}

		/// <summary>
		/// Request the user info of the specified platform.
		/// </summary>
		/// <param name="platform">Platform.</param>
		public void showUser(int platform, GetUserInfoResultEvent resultHandler) {
			showUserHandler = resultHandler;
			ssdk.CallStatic("showUser", platform);
		}

		/// <summary>
		/// Share the content to the specified platform.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="content">Content.</param>
		/// <param name="resultHandler">Result handler.</param>
		public void share(int platform, Hashtable content, ShareResultEvent resultHandler) {
			shareHandler = resultHandler;
			String json = MiniJSON.jsonEncode(content);
			ssdk.CallStatic("share", platform, json);
		}

		/// <summary>
		/// GUI share.
		/// </summary>
		/// <param name="content">Content.</param>
		/// <param name="resultHandler">Result handler.</param>
		public void onekeyShare(Hashtable content, ShareResultEvent resultHandler) {
			onekeyShare(0, content, resultHandler);
		}

		/// <summary>
		/// OGUI share to the specified platform. 
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="content">Content.</param>
		/// <param name="resultHandler">Result handler.</param>
		public void onekeyShare(int platform, Hashtable content, ShareResultEvent resultHandler) {
			shareHandler = resultHandler;
			String json = MiniJSON.jsonEncode(content);
			ssdk.CallStatic("onekeyShare", platform, json);
		}

		/// <summary>
		/// Java callback.
		/// </summary>
		/// <param name="message">Message.</param>
		public void onActionCallback(string message) {
			if (message == null) {
				return;
			}

			Hashtable res = (Hashtable) MiniJSON.jsonDecode(message);
			if (res == null || res.Count <= 0) {
				return;
			}

			int status = Convert.ToInt32(res["status"]);
			int platform = Convert.ToInt32(res["platform"]);
			int action = Convert.ToInt32(res["action"]);
			// Success = 1, Fail = 2, Cancel = 3
			switch(status) {
				case 1: {
					Console.WriteLine(message);
					Hashtable resp = (Hashtable) res["res"];
					OnComplete(platform, action, resp);
				} break;
				case 2: {
					Console.WriteLine(message);
					Hashtable throwable = (Hashtable) res["res"];
					OnError(platform, action, throwable);
				} break;
				case 3: {
					OnCancel(platform, action);
				} break;
			}
		}

		/// <summary>
		/// Raises the error event.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="action">Action.</param>
		/// <param name="throwable">Throwable.</param>
		private void OnError(int platform, int action, Hashtable throwable) {
			switch (action) {
				case 1: { // 1 == Platform.ACTION_AUTHORIZING
					if (authHandler != null) {
						authHandler(ResponseState.Fail, (PlatformType) platform, throwable);
					}
				} break;
				case 8: { // 8 == Platform.ACTION_USER_INFOR
					if (showUserHandler != null) {
						showUserHandler(ResponseState.Fail, (PlatformType) platform, null, throwable);
					}
				} break;
				case 9: { // 9 == Platform.ACTION_SHARE
					if (shareHandler != null) {
						shareHandler(ResponseState.Fail, (PlatformType) platform, null, throwable, false);
					}
				} break;
			}
		}

		/// <summary>
		/// Raises the success event.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="action">Action.</param>
		/// <param name="res">Res.</param>
		private void OnComplete(int platform, int action, Hashtable res) {
			switch (action) {
				case 1: { // 1 == Platform.ACTION_AUTHORIZING
					if (authHandler != null) {
						authHandler(ResponseState.Success, (PlatformType) platform, null);
					}
				} break;
				case 8: { // 8 == Platform.ACTION_USER_INFOR
					if (showUserHandler != null) {
						showUserHandler(ResponseState.Success, (PlatformType) platform, res, null);
					}
				} break;
				case 9: { // 9 == Platform.ACTION_SHARE
					if (shareHandler != null) {
						shareHandler(ResponseState.Success, (PlatformType) platform, res, null, false);
					}
				} break;
			}
		}

		/// <summary>
		/// Raises the cancel event.
		/// </summary>
		/// <param name="platform">Platform.</param>
		/// <param name="action">Action.</param>
		private void OnCancel(int platform, int action) {
			switch (action) {
				case 1: { // 1 == Platform.ACTION_AUTHORIZING
					if (authHandler != null) {
						authHandler(ResponseState.Cancel, (PlatformType) platform, null);
					}
				} break;
				case 8: { // 8 == Platform.ACTION_USER_INFOR
					if (showUserHandler != null) {
						showUserHandler(ResponseState.Cancel, (PlatformType) platform, null, null);
					}
				} break;
				case 9: { // 9 == Platform.ACTION_SHARE
					if (shareHandler != null) {
						shareHandler(ResponseState.Cancel, (PlatformType) platform, null, null, false);
					}
				} break;
			}
		}
		
	}
#endif
}
