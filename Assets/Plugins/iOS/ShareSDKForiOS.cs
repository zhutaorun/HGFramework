using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace cn.sharesdk.unity3d.ios
{
#if UNITY_IPHONE
	public static class ShareSDK
	{
	
		[DllImport("__Internal")]
		private static extern void __iosShareSDKOpen (string appKey);
			
		[DllImport("__Internal")]
		private static extern void __iosShareSDKSetPlatformConfig (int platType, string configInfo);
			
		[DllImport("__Internal")]
		private static extern void __iosShareSDKAuthorize (int platType, string observer);
			
		[DllImport("__Internal")]
		private static extern void __iosShareSDKCancelAuthorize (int platType);
			
		[DllImport("__Internal")]
		private static extern bool __iosShareSDKHasAuthorized (int platType);
			
		[DllImport("__Internal")]
		private static extern void __iosShareSDKGetUserInfo (int platType, string observer);
			
		[DllImport("__Internal")]
		private static extern void __iosShareSDKShare (int platType, string content, string observer);
			
		[DllImport("__Internal")]
		private static extern void __iosShareSDKOneKeyShare (string platTypes, string content, string observer);
			
		[DllImport("__Internal")]
		private static extern void __iosShareSDKShowShareMenu (string platTypes, string content, int x, int y, int direction, string observer);
			
		[DllImport("__Internal")]
		private static extern void __iosShareSDKShowShareView (int platType, string content, string observer);
		
		private static AuthResultEvent _authResultEvent = null;
		private static GetUserInfoResultEvent _getUserInfoResultEvent = null;
		private static ShareResultEvent _shareResultEvent = null;
		
		private static string _callbackObjectName = "Main Camera";
		
		/// <summary>
		/// Authorizes the result handler.
		/// </summary>
		/// <param name='data'>
		/// Data.
		/// </param>
		private static void _authorizeResultHandler (Hashtable data)
		{	
			ResponseState state = ResponseState.Cancel;
			PlatformType type = PlatformType.Any;
			Hashtable error = null;
			
			if (data.ContainsKey ("state"))
			{
				state = (ResponseState)Convert.ToInt32(data ["state"]);
			}
			if (data.ContainsKey ("type"))
			{
				type = (PlatformType)Convert.ToInt32 (data ["type"]);
			}
			if (data.ContainsKey ("error"))
			{
				error = (Hashtable)data ["error"];
			}
			
			_authResultEvent (state, type, error);
		}
		
		/// <summary>
		/// gets the user info result handler.
		/// </summary>
		/// <param name='data'>
		/// Data.
		/// </param>
		private static void _getUserInfoResultHandler (Hashtable data)
		{
			ResponseState state = ResponseState.Cancel;
			PlatformType type = PlatformType.Any;
			Hashtable user = null;
			Hashtable error = null;
			
			if (data.ContainsKey ("state"))
			{
				state = (ResponseState)Convert.ToInt32(data ["state"]);
			}
			if (data.ContainsKey ("type"))
			{
				type = (PlatformType)Convert.ToInt32 (data ["type"]);
			}
			if (data.ContainsKey ("user"))
			{
				user = (Hashtable)data ["user"];
			}
			if (data.ContainsKey ("error"))
			{
				error = (Hashtable)data ["error"];
			}
			
			_getUserInfoResultEvent (state, type, user, error);
		}
		
		/// <summary>
		/// _shares the result handler.
		/// </summary>
		/// <param name='data'>
		/// Data.
		/// </param>
		private static void _shareResultHandler (Hashtable data)
		{
			ResponseState state = ResponseState.Cancel;
			PlatformType type = PlatformType.Any;
			bool end = true;
			Hashtable shareInfo = null;
			Hashtable error = null;
			
			if (data.ContainsKey ("state"))
			{
				state = (ResponseState)Convert.ToInt32(data ["state"]);
			}
			if (data.ContainsKey ("type"))
			{
				type = (PlatformType)Convert.ToInt32 (data ["type"]);
			}
			if (data.ContainsKey ("end"))
			{
				end = Convert.ToBoolean (data["end"]);
			}
			if (data.ContainsKey ("share_info"))
			{
				shareInfo = (Hashtable)data ["share_info"];
			}
			if (data.ContainsKey ("error"))
			{
				error = (Hashtable)data ["error"];
			}
			
			_shareResultEvent (state, type, shareInfo, error, end);
		}
		
		/// <summary>
		/// Callback the specified data.
		/// </summary>
		/// <param name='data'>
		/// Data.
		/// </param>
		public static void callback (string data)
		{
			object dataObj = MiniJSON.jsonDecode (data);
			if (dataObj is Hashtable)
			{
				Hashtable dataTable = dataObj as Hashtable;
				if (dataTable != null && dataTable.ContainsKey("action"))
				{
					int action = System.Convert.ToInt32 (dataTable ["action"]);
					switch (action)
					{
					case 1:
						//Authorized
						_authorizeResultHandler (dataTable);
						break;
					case 2:
						//Get User Info
						_getUserInfoResultHandler (dataTable);
						break;
					case 3:
						//Share
						_shareResultHandler (dataTable);
						break;
					}
				}
			}
		}
		
		/// <summary>
		/// Sets the name of the callback object.
		/// </summary>
		/// <param name='objectName'>
		/// Object name.
		/// </param>
		public static void setCallbackObjectName (string objectName)
		{
			_callbackObjectName = objectName;
		}
		
		/// <summary>
		/// Initialize ShareSDK
		/// </summary>
		/// <param name='appKey'>
		/// App key.
		/// </param>
		public static void open (string appKey)
		{
			__iosShareSDKOpen (appKey);
		}
		
		/// <summary>
		/// Close this instance.
		/// </summary>
		public static void close ()
		{

		}
		
		/// <summary>
		/// Sets the platform config.
		/// </summary>
		/// <param name='type'>
		/// Type.
		/// </param>
		/// <param name='configInfo'>
		/// Config info.
		/// </param>
		public static void setPlatformConfig (PlatformType type, Hashtable configInfo)
		{
			string confStr = null;
			if (configInfo != null)
			{
				confStr = MiniJSON.jsonEncode (configInfo);
			}
			__iosShareSDKSetPlatformConfig ((int)type, confStr);
		}
		
		/// <summary>
		/// Authorize the specified type, observer and resultHandler.
		/// </summary>
		/// <param name='type'>
		/// Type.
		/// </param>
		/// <param name='observer'>
		/// Observer.
		/// </param>
		/// <param name='resultHandler'>
		/// Result handler.
		/// </param>
		public static void authorize (PlatformType type, AuthResultEvent resultHandler)
		{
			_authResultEvent = resultHandler;
			__iosShareSDKAuthorize ((int)type, _callbackObjectName);
		}
		
		/// <summary>
		/// Cancel authorized
		/// </summary>
		/// <param name='type'>
		/// Type.
		/// </param>
		public static void cancelAuthorie (PlatformType type)
		{
			__iosShareSDKCancelAuthorize ((int)type);
		}
		
		/// <summary>
		/// Has authorized
		/// </summary>
		/// <returns>
		/// true has authorized, otherwise not authorized.
		/// </returns>
		/// <param name='type'>
		/// Type.
		/// </param>
		public static bool hasAuthorized (PlatformType type)
		{
			return __iosShareSDKHasAuthorized ((int)type);
		}
		
		/// <summary>
		/// Gets the user info.
		/// </summary>
		/// <param name='type'>
		/// Type.
		/// </param>
		/// <param name='callback'>
		/// Callback.
		/// </param>
		public static void getUserInfo (PlatformType type, GetUserInfoResultEvent resultHandler)
		{
			_getUserInfoResultEvent = resultHandler;
			__iosShareSDKGetUserInfo ((int)type, _callbackObjectName);
		}
	
		/// <summary>
		/// Shares the content.
		/// </summary>
		/// <param name='type'>
		/// Type.
		/// </param>
		/// <param name='content'>
		/// Content.
		/// </param>
		/// <param name='resultHandler'>
		/// Callback.
		/// </param>
		public static void shareContent (PlatformType type, Hashtable content, ShareResultEvent resultHandler)
		{
			_shareResultEvent = resultHandler;
			
			string contentStr = null;
			if (content != null)
			{
				contentStr = MiniJSON.jsonEncode(content);
			}
			
			__iosShareSDKShare ((int)type, contentStr, _callbackObjectName);
		}
		
		/// <summary>
		/// share content to multiple platform
		/// </summary>
		/// <param name='types'>
		/// Types.
		/// </param>
		/// <param name='content'>
		/// Content.
		/// </param>
		/// <param name='resultHandler'>
		/// Callback.
		/// </param>
		public static void oneKeyShareContent (PlatformType[] types, Hashtable content, ShareResultEvent resultHandler)
		{
			_shareResultEvent = resultHandler;
			
			string platTypesStr = null;
			if (types != null)
			{
				List<int> platTypesArr = new List<int>();
				foreach (PlatformType type in types)
				{
					platTypesArr.Add((int)type);
				}
				platTypesStr = MiniJSON.jsonEncode(platTypesArr.ToArray());
			}
			
			__iosShareSDKOneKeyShare (platTypesStr, MiniJSON.jsonEncode(content), _callbackObjectName);
		}
		
		/// <summary>
		/// Shows the share menu.
		/// </summary>
		/// <param name='types'>
		/// Types.
		/// </param>
		/// <param name='content'>
		/// Content.
		/// </param>
		/// <param name='x'>
		/// X.
		/// </param>
		/// <param name='y'>
		/// Y.
		/// </param>
		/// <param name='direction'>
		/// Direction.
		/// </param>
		/// <param name='callback'>
		/// Callback.
		/// </param>
		public static void showShareMenu (PlatformType[] types, Hashtable content, int x, int y, MenuArrowDirection direction, ShareResultEvent resultHandler)
		{
			_shareResultEvent = resultHandler;
			
			string platTypesStr = null;
			if (types != null)
			{
				List<int> platTypesArr = new List<int>();
				foreach (PlatformType type in types)
				{
					platTypesArr.Add((int)type);
				}
				platTypesStr = MiniJSON.jsonEncode(platTypesArr.ToArray());
			}
			
			__iosShareSDKShowShareMenu (platTypesStr, MiniJSON.jsonEncode(content), x, y, (int)direction, _callbackObjectName);
		}
		
		/// <summary>
		/// Shows the share view.
		/// </summary>
		/// <param name='type'>
		/// Type.
		/// </param>
		/// <param name='content'>
		/// Content.
		/// </param>
		/// <param name='callback'>
		/// Callback.
		/// </param>
		public static void showShareView (PlatformType type, Hashtable content, ShareResultEvent resultHandler)
		{
			_shareResultEvent = resultHandler;
			
			__iosShareSDKShowShareView ((int)type, MiniJSON.jsonEncode(content), _callbackObjectName);
		}
	}
#endif
}