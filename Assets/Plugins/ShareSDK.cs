using UnityEngine;
using System.Collections;
using System;  
using System.Collections.Generic;  
using System.IO;  
using System.Text; 

namespace cn.sharesdk.unity3d
{
	/// <summary>
	/// Platform type.
	/// </summary>
	public enum PlatformType
	{
		SinaWeibo = 1,			//Sina Weibo         
		TencentWeibo = 2,		//Tencent Weibo     
		SohuWeibo = 3,			//Sohu Weibo         
		NetEaseWeibo = 4,		//NetEase Weibo         
		DouBan = 5,				//Dou Ban           
		QZone = 6, 				//QZone           
		Renren = 7,				//Ren Ren           
		Kaixin = 8,				//Kai Xin          
		Pengyou = 9,			//Friends          
		Facebook = 10,			//Facebook         
		Twitter = 11,			//Twitter         
		Evernote = 12,			//Evernote        
		Foursquare = 13,		//Foursquare      
		GooglePlus = 14,		//Google+       
		Instagram = 15,			//Instagram      
		LinkedIn = 16,			//LinkedIn       
		Tumblr = 17,			//Tumblr         
		Mail = 18, 				//Mail          
		SMS = 19,				//SMS           
		Print = 20, 			//Print       
		Copy = 21,				//Copy             
		WeChatSession = 22,		//WeChat Session    
		WeChatTimeline = 23,	//WeChat Timeline   
		QQ = 24,				//QQ              
		Instapaper = 25,		//Instapaper       
		Pocket = 26,			//Pocket           
		YouDaoNote = 27, 		//You Dao Note     
		SohuKan = 28, 			//Sohu Sui Shen Kan         
		Pinterest = 30, 		//Pinterest     
		Flickr = 34,			//Flickr          
		Dropbox = 35,			//Dropbox          
		VKontakte = 36,			//VKontakte       
		WeChatFav = 37,			//WeChat Favorited        
		YiXinSession = 38, 		//YiXin Session   
		YiXinTimeline = 39,		//YiXin Timeline   
		YiXinFav = 40,			//YiXin Favorited        
		Any = 99 				//Any Platform 
	}

	/// <summary>
	/// Response state.
	/// </summary>
	public enum ResponseState
	{
		Begin = 0,				//Begin
		Success = 1,			//Success
		Fail = 2,				//Failure
		Cancel = 3				//Cancel
	}
	
	/// <summary>
	/// Menu arrow direction.
	/// </summary>
	public enum MenuArrowDirection
	{
		Up = 1 << 0,						//Up
		Down = 1 << 1,						//Down
		Left = 1 << 2,						//Left
		Right = 1 << 3,						//Right
		Any =  Up | Down | Left | Right,	//Any
		Unknown = int.MaxValue				//Unkonwn
	}
	
	/// <summary>
	/// Content type.
	/// </summary>
    public enum ContentType
    {
		Text = 0, 				//Text
		Image = 1,				//Image 
		News = 2,				//News 
		Music = 3,				//Music 
		Video = 4,				//Video 
		App = 5, 				//App
		NonGif = 6,				//Non Gif Image 
		Gif = 7,				//Gif Image 
		File = 8				//File
    };
	
	/// <summary>
	/// Auth result event.
	/// </summary>
	public delegate void AuthResultEvent (ResponseState state, PlatformType type, Hashtable error);
	
	/// <summary>
	/// Get user info result event.
	/// </summary>
	public delegate void GetUserInfoResultEvent (ResponseState state, PlatformType type, Hashtable userInfo, Hashtable error);
	
	/// <summary>
	/// Share result event.
	/// </summary>
	public delegate void ShareResultEvent (ResponseState state, PlatformType type, Hashtable shareInfo, Hashtable error, bool end);
	
	/// <summary>
	/// ShareSDK.
	/// </summary>
	public class ShareSDK : MonoBehaviour 
	{
		
		/// <summary>
		/// callback the specified data.
		/// </summary>
		/// <param name='data'>
		/// Data.
		/// </param>
		private void _callback (string data)
		{
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.callback (data);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				AndroidUtils.getInstance().onActionCallback(data);
#endif
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
			if (objectName == null)
			{
				objectName = "Main Camera";
			}
			
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.setCallbackObjectName(objectName);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				AndroidUtils.getInstance().setGameObject(objectName);
#endif
			}
		}
		
		/// <summary>
		/// Initialize ShareSDK
		/// </summary>
		/// <param name='appKey'>
		/// App key.
		/// </param>
		public static void open (string appKey)
		{
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.open (appKey);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				//AndroidUtils.getInstance().initSDK();
				// if you don't add ShareSDK.xml in your assets folder, use the following line
				AndroidUtils.getInstance().initSDK(appKey);
#endif
			}
		}
		
		/// <summary>
		/// Close this instance.
		/// </summary>
		public static void close ()
		{
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.close ();
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				AndroidUtils.getInstance().stopSDK();
#endif
			}
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
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.setPlatformConfig (type, configInfo);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				// if you don't add ShareSDK.xml in your assets folder, use the following line
				AndroidUtils.getInstance().setPlatformConfig((int)type, configInfo);
#endif
			}
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
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.authorize (type, resultHandler);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				AndroidUtils.getInstance().authorize((int) type, resultHandler);
#endif
			}
		}
		
		/// <summary>
		/// Cancel authorized
		/// </summary>
		/// <param name='type'>
		/// Type.
		/// </param>
		public static void cancelAuthorie (PlatformType type)
		{
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.cancelAuthorie (type);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				AndroidUtils.getInstance().removeAccount((int) type);
#endif
			}
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
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				return ios.ShareSDK.hasAuthorized (type);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				return AndroidUtils.getInstance().isValid((int) type);
#endif
			}
			
			return false;
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
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.getUserInfo (type, resultHandler);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				AndroidUtils.getInstance().showUser((int) type, resultHandler);
#endif
			}
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
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.shareContent (type, content, resultHandler);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				AndroidUtils.getInstance().share((int) type, content, resultHandler);
#endif
			}
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
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.oneKeyShareContent (types, content, resultHandler);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				foreach (PlatformType type in types) 
				{
					AndroidUtils.getInstance().share((int) type, content, resultHandler);
				}
#endif
			}
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
		/// X. only for iPad
		/// </param>
		/// <param name='y'>
		/// Y. only for iPad
		/// </param>
		/// <param name='direction'>
		/// Direction. only for iPad
		/// </param>
		/// <param name='callback'>
		/// Callback.
		/// </param>
		public static void showShareMenu (PlatformType[] types, Hashtable content, int x, int y, MenuArrowDirection direction, ShareResultEvent resultHandler)
		{
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.showShareMenu (types, content, x, y, direction, resultHandler);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				// The android platform doesn't have this method, you can modify the PlatformGridView class of OnekeyShare in java layer to achieve this function
				AndroidUtils.getInstance().onekeyShare(content, resultHandler);
#endif
			}
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
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
#if UNITY_IPHONE
				ios.ShareSDK.showShareView (type, content, resultHandler);
#endif
			}
			else if (Application.platform == RuntimePlatform.Android)
			{
#if UNITY_ANDROID
				AndroidUtils.getInstance().onekeyShare(content, resultHandler);
				// if you want to skip the PlatformGridView, use the following line
				// AndroidUtils.getInstance().onekeyShare((int) type, content, resultHandler);
#endif
			}
		}
	}
}