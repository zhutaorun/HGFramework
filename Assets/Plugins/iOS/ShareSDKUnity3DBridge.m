//
//  ShareSDKUnity3DBridge.m
//  Unity-iPhone
//
//  Created by 冯 鸿杰 on 14-2-14.
//
//

#import "ShareSDKUnity3DBridge.h"
#import <ShareSDK/ShareSDK.h>
#import <SHareSDK/ShareSDK+Utils.h>
#import <AGCommon/CMRegexKitLite.h>
#import <AGCommon/UIDevice+Common.h>

#define __SHARESDK_WECHAT__
#define __SHARESDK_YIXIN__
#define __SHARESDK_PINTEREST__
#define __SHARESDK_GOOGLEPLUS__
#define __SHARESDK_QQ__
#define __SHARESDK_RENREN__
#define __SHARESDK_TENCENT_WEIBO__

#ifdef __SHARESDK_WECHAT__
#import "WXApi.h"
#endif

#ifdef __SHARESDK_YIXIN__
#import "YXApi.h"
#endif

#ifdef __SHARESDK_PINTEREST__
#import <Pinterest/Pinterest.h>
#endif

#ifdef __SHARESDK_GOOGLEPLUS__
#import <GoogleOpenSource/GoogleOpenSource.h>
#import <GooglePlus/GooglePlus.h>
#endif

#ifdef __SHARESDK_QQ__
#import <TencentOpenAPI/TencentOAuth.h>
#import <TencentOpenAPI/QQApiInterface.h>
#endif

#ifdef __SHARESDK_RENREN__
#import <RennSDK/RennSDK.h>
#endif

#ifdef __SHARESDK_TENCENT_WEIBO__
#import "WeiboApi.h"
#endif

static UIView *_refView = nil;

#if defined (__cplusplus)
extern "C" {
#endif
    
    /**
     *	@brief	初始化ShareSDK
     *
     *	@param 	appKey 	应用Key
     */
    extern void __iosShareSDKOpen(void *appKey);

    /**
     *	@brief	初始化社交平台
     *
     *	@param 	platType 	平台类型
     *	@param 	contigInfo 	配置信息
     */
    extern void __iosShareSDKSetPlatformConfig(int platType, void *configInfo);

    /**
     *	@brief	用户授权
     *
     *	@param 	platType 	平台类型
     *  @param  observer    观察回调对象名称
     */
    extern void __iosShareSDKAuthorize (int platType, void *observer);

    /**
     *	@brief	取消用户授权
     *
     *	@param 	platType 	平台类型
     */
    extern void __iosShareSDKCancelAuthorize (int platType);

    /**
     *	@brief	判断用户是否授权
     *
     *	@param 	platType 	平台类型
     *
     *	@return	YES 表示已经授权，NO 表示尚未授权
     */
    extern bool __iosShareSDKHasAuthorized (int platType);
    
    /**
     *	@brief	获取用户信息
     *
     *	@param 	platType 	平台类型
     *  @param  observer    观察回调对象名称
     */
    extern void __iosShareSDKGetUserInfo (int platType, void *observer);
    
    /**
     *	@brief	分享内容
     *
     *	@param 	platType 	平台类型
     *	@param 	content 	分享内容
     *  @param  observer    观察回调对象名称
     */
    extern void __iosShareSDKShare (int platType, void *content, void *observer);

    /**
     *	@brief	一键分享内容
     *
     *	@param 	platTypes 	平台类型列表
     *	@param 	content 	分享内容
     *  @param  observer    观察回调对象名称
     */
    extern void __iosShareSDKOneKeyShare (void *platTypes, void *content, void *observer);
    
    /**
     *	@brief	显示分享菜单
     *
     *	@param 	platTypes 	平台类型列表
     *	@param 	content 	分享内容
     *	@param 	x 	弹出菜单的箭头的横坐标，仅用于iPad
     *	@param 	y 	弹出菜单的箭头的纵坐标，仅用于iPad
     *	@param 	direction 	菜单箭头方向，仅用于iPad
     *  @param  observer    观察回调对象名称
     */
    extern void __iosShareSDKShowShareMenu (void *platTypes, void *content, int x, int y, int direction, void *observer);

    /**
     *	@brief	显示分享编辑界面
     *
     *	@param 	platType 	平台类型
     *	@param 	content 	分享内容
     *  @param  observer    观察回调对象名称
     */
    extern void __iosShareSDKShowShareView (int platType, void *content, void *observer);

    
#if defined (__cplusplus)
}
#endif

#if defined (__cplusplus)
extern "C" {
#endif
    
    id<ISSContent> __getContentObjectWithString(NSString *data)
    {
        NSDictionary *contentDict = [ShareSDK jsonObjectWithString:data];
        
        
        NSString *message = nil;
        id<ISSCAttachment> image = nil;
        NSString *title = nil;
        NSString *url = nil;
        NSString *desc = nil;
        SSPublishContentMediaType type = SSPublishContentMediaTypeText;
        
        
        
        if (contentDict)
        {
            if ([[contentDict objectForKey:@"content"] isKindOfClass:[NSString class]])
            {
                message = [contentDict objectForKey:@"content"];
            }
            if ([[contentDict objectForKey:@"image"] isKindOfClass:[NSString class]])
            {
                NSString *imagePath = [contentDict objectForKey:@"image"];
                if ([imagePath isMatchedByRegex:@"\\w://.*"])
                {
                    image = [ShareSDK imageWithUrl:imagePath];
                }
                else
                {
                    image = [ShareSDK imageWithPath:imagePath];
                }
            }
            if ([[contentDict objectForKey:@"title"] isKindOfClass:[NSString class]])
            {
                title = [contentDict objectForKey:@"title"];
            }
            if ([[contentDict objectForKey:@"url"] isKindOfClass:[NSString class]])
            {
                url = [contentDict objectForKey:@"url"];
            }
            if ([[contentDict objectForKey:@"description"] isKindOfClass:[NSString class]])
            {
                desc = [contentDict objectForKey:@"description"];
            }
            if ([[contentDict objectForKey:@"type"] isKindOfClass:[NSString class]])
            {
                type = (SSPublishContentMediaType)[[contentDict objectForKey:@"type"] integerValue];
            }
        }
        
        id<ISSContent> contentObj = [ShareSDK content:message
                                       defaultContent:nil
                                                image:image
                                                title:title
                                                  url:url
                                          description:desc
                                            mediaType:type];
        
        if (contentDict)
        {
            NSString *site = nil;
            NSString *siteUrl = nil;
            
            if ([[contentDict objectForKey:@"site"] isKindOfClass:[NSString class]])
            {
                site = [contentDict objectForKey:@"site"];
            }
            
            if ([[contentDict objectForKey:@"siteUrl"] isKindOfClass:[NSString class]])
            {
                siteUrl = [contentDict objectForKey:@"siteUrl"];
            }
            
            if (site || siteUrl)
            {
                [contentObj addQQSpaceUnitWithTitle:INHERIT_VALUE
                                                url:INHERIT_VALUE
                                               site:site
                                            fromUrl:siteUrl
                                            comment:INHERIT_VALUE
                                            summary:INHERIT_VALUE
                                              image:INHERIT_VALUE
                                               type:INHERIT_VALUE
                                            playUrl:INHERIT_VALUE
                                               nswb:INHERIT_VALUE];
            }
            
            
            NSString *extInfo = nil;
            NSString *musicUrl = nil;
            
            if ([[contentDict objectForKey:@"extInfo"] isKindOfClass:[NSString class]])
            {
                extInfo = [contentDict objectForKey:@"extInfo"];
            }
            
            if ([[contentDict objectForKey:@"musicUrl"] isKindOfClass:[NSString class]])
            {
                musicUrl = [contentDict objectForKey:@"musicUrl"];
            }
            
            if (extInfo || musicUrl)
            {
                [contentObj addWeixinSessionUnitWithType:INHERIT_VALUE
                                                 content:INHERIT_VALUE
                                                   title:INHERIT_VALUE
                                                     url:INHERIT_VALUE
                                                   image:INHERIT_VALUE
                                            musicFileUrl:musicUrl
                                                 extInfo:extInfo
                                                fileData:INHERIT_VALUE
                                            emoticonData:INHERIT_VALUE];
                
                [contentObj addWeixinTimelineUnitWithType:INHERIT_VALUE
                                                  content:INHERIT_VALUE
                                                    title:INHERIT_VALUE
                                                      url:INHERIT_VALUE
                                                    image:INHERIT_VALUE
                                             musicFileUrl:musicUrl
                                                  extInfo:extInfo
                                                 fileData:INHERIT_VALUE
                                             emoticonData:INHERIT_VALUE];
                
                [contentObj addWeixinFavUnitWithType:INHERIT_VALUE
                                             content:INHERIT_VALUE
                                               title:INHERIT_VALUE
                                                 url:INHERIT_VALUE
                                          thumbImage:INHERIT_VALUE
                                               image:INHERIT_VALUE
                                        musicFileUrl:musicUrl
                                             extInfo:extInfo
                                            fileData:INHERIT_VALUE
                                        emoticonData:INHERIT_VALUE];
            }
        }
        
        return contentObj;
    }
    
    
    void __iosShareSDKOpen(void *appKey)
    {
        NSString *appKeyStr = [NSString stringWithCString:appKey encoding:NSUTF8StringEncoding];
        [ShareSDK registerApp:appKeyStr];
        
#ifdef __SHARESDK_WECHAT__
        [ShareSDK importWeChatClass:[WXApi class]];
#endif
        
#ifdef __SHARESDK_YIXIN__
        [ShareSDK importYiXinClass:[YXApi class]];
#endif
        
#ifdef __SHARESDK_PINTEREST__
        [ShareSDK importPinterestClass:[Pinterest class]];
#endif
        
#ifdef __SHARESDK_GOOGLEPLUS__
        [ShareSDK importGooglePlusClass:[GPPSignIn class] shareClass:[GPPShare class]];
#endif
        
#ifdef __SHARESDK_QQ__
        [ShareSDK importQQClass:[QQApiInterface class] tencentOAuthCls:[TencentOAuth class]];
#endif
        
#ifdef __SHARESDK_RENREN__
        [ShareSDK importRenRenClass:[RennClient class]];
#endif
      
#ifdef __SHARESDK_TENCENT_WEIBO__
        [ShareSDK importTencentWeiboClass:[WeiboApi class]];
#endif
    }
    
    void __iosShareSDKSetPlatformConfig(int platType, void *configInfo)
    {
        NSString *configInfoStr = nil;
        if (configInfo)
        {
            configInfoStr = [NSString stringWithCString:configInfo encoding:NSUTF8StringEncoding];
        }
        NSMutableDictionary *configInfoDict = [NSMutableDictionary dictionaryWithDictionary:[ShareSDK jsonObjectWithString:configInfoStr]];
        
        switch (platType)
        {
            case ShareTypeWeixiSession:
            case ShareTypeYiXinSession:
                [configInfoDict setObject:[NSNumber numberWithInt:0] forKey:@"scene"];
                break;
            case ShareTypeWeixiTimeline:
            case ShareTypeYiXinTimeline:
                [configInfoDict setObject:[NSNumber numberWithInt:1] forKey:@"scene"];
                break;
            case ShareTypeWeixiFav:
                [configInfoDict setObject:[NSNumber numberWithInt:2] forKey:@"scene"];
                break;
            default:
                break;
        }
        
        [ShareSDK connectPlatformWithType:platType
                                 platform:nil
                                  appInfo:configInfoDict];
    }
    
    void __iosShareSDKAuthorize (int platType, void *observer)
    {
        NSString *observerStr = nil;
        if (observer)
        {
            observerStr = [NSString stringWithCString:observer encoding:NSUTF8StringEncoding];
        }
        
        [ShareSDK authWithType:platType
                       options:nil
                        result:^(SSAuthState state, id<ICMErrorInfo> error) {
                            
                            NSMutableDictionary *resultDict = [NSMutableDictionary dictionary];
                            [resultDict setObject:[NSNumber numberWithInteger:1] forKey:@"action"];
                            [resultDict setObject:[NSNumber numberWithInteger:state] forKey:@"state"];
                            [resultDict setObject:[NSNumber numberWithInteger:platType] forKey:@"type"];
                            
                            if (state == SSResponseStateFail && error)
                            {
                                NSMutableDictionary *errorDict = [NSMutableDictionary dictionary];
                                [errorDict setObject:[NSNumber numberWithInteger:[error errorCode]] forKey:@"error_code"];
                                if ([error errorDescription])
                                {
                                    [errorDict setObject:[error errorDescription] forKey:@"error_msg"];
                                }
                                [resultDict setObject:errorDict forKey:@"error"];
                            }
                            
                            NSString *resultStr = [ShareSDK jsonStringWithObject:resultDict];
                            UnitySendMessage([observerStr UTF8String], "_callback", [resultStr UTF8String]);
                        }];
    }
    
    void __iosShareSDKCancelAuthorize (int platType)
    {
        [ShareSDK cancelAuthWithType:platType];
    }
    
    bool __iosShareSDKHasAuthorized (int platType)
    {
        return [ShareSDK hasAuthorizedWithType:platType];
    }
    
    void __iosShareSDKGetUserInfo (int platType, void *observer)
    {
        NSString *observerStr = nil;
        if (observer)
        {
            observerStr = [NSString stringWithCString:observer encoding:NSUTF8StringEncoding];
        }
        
        [ShareSDK getUserInfoWithType:platType
                          authOptions:nil
                               result:^(BOOL result, id<ISSPlatformUser> userInfo, id<ICMErrorInfo> error) {
                                   
                                   NSMutableDictionary *resultDict = [NSMutableDictionary dictionary];
                                   [resultDict setObject:[NSNumber numberWithInteger:2] forKey:@"action"];
                                   [resultDict setObject:[NSNumber numberWithInteger:result ? SSResponseStateSuccess : SSResponseStateFail] forKey:@"state"];
                                   [resultDict setObject:[NSNumber numberWithInteger:platType] forKey:@"type"];
                                   
                                   if (!result && error)
                                   {
                                       NSMutableDictionary *errorDict = [NSMutableDictionary dictionary];
                                       [errorDict setObject:[NSNumber numberWithInteger:[error errorCode]] forKey:@"error_code"];
                                       if ([error errorDescription])
                                       {
                                           [errorDict setObject:[error errorDescription] forKey:@"error_msg"];
                                       }
                                       [resultDict setObject:errorDict forKey:@"error"];
                                   }
                                   else if ([userInfo sourceData])
                                   {
                                       [resultDict setObject:[userInfo sourceData] forKey:@"user"];
                                   }
                                   
                                   NSString *resultStr = [ShareSDK jsonStringWithObject:resultDict];
                                   UnitySendMessage([observerStr UTF8String], "_callback", [resultStr UTF8String]);
                                   
                               }];
    }
    
    void __iosShareSDKShare (int platType, void *content, void *observer)
    {
        NSString *observerStr = nil;
        id<ISSContent> contentObj = nil;
        
        observerStr = [NSString stringWithCString:observer encoding:NSUTF8StringEncoding];
        
        if (content)
        {
            NSString *contentStr = [NSString stringWithCString:content encoding:NSUTF8StringEncoding];
            contentObj = __getContentObjectWithString(contentStr);
        }
        
        [ShareSDK shareContent:contentObj
                          type:platType
                   authOptions:nil
                  shareOptions:nil
                 statusBarTips:NO
                        result:^(ShareType type, SSResponseState state, id<ISSPlatformShareInfo> statusInfo, id<ICMErrorInfo> error, BOOL end) {
                            
                            NSMutableDictionary *resultDict = [NSMutableDictionary dictionary];
                            [resultDict setObject:[NSNumber numberWithInteger:3] forKey:@"action"];
                            [resultDict setObject:[NSNumber numberWithInteger:state] forKey:@"state"];
                            [resultDict setObject:[NSNumber numberWithInteger:platType] forKey:@"type"];
                            [resultDict setObject:[NSNumber numberWithBool:end] forKey:@"end"];
                            
                            if (state == SSResponseStateFail && error)
                            {
                                NSMutableDictionary *errorDict = [NSMutableDictionary dictionary];
                                [errorDict setObject:[NSNumber numberWithInteger:[error errorCode]] forKey:@"error_code"];
                                if ([error errorDescription])
                                {
                                    [errorDict setObject:[error errorDescription] forKey:@"error_msg"];
                                }
                                [resultDict setObject:errorDict forKey:@"error"];
                            }
                            else if ([statusInfo sourceData])
                            {
                                if (type == ShareTypeRenren)
                                {
                                    [resultDict setObject:@{@"postid" : [statusInfo sourceData]}
                                                   forKey:@"share_info"];
                                }
                                else
                                {
                                    [resultDict setObject:[statusInfo sourceData]
                                                   forKey:@"share_info"];
                                }
                            }
                            
                            NSString *resultStr = [ShareSDK jsonStringWithObject:resultDict];
                            UnitySendMessage([observerStr UTF8String], "_callback", [resultStr UTF8String]);
                        }];
    }
    
    void __iosShareSDKOneKeyShare (void *platTypes, void *content, void *observer)
    {
        NSArray *platTypesArr = nil;
        NSString *observerStr = nil;
        id<ISSContent> contentObj = nil;
        
        observerStr = [NSString stringWithCString:observer encoding:NSUTF8StringEncoding];
        
        if (platTypes)
        {
            NSString *platTypesStr = [NSString stringWithCString:platTypes encoding:NSUTF8StringEncoding];
            platTypesArr = [ShareSDK jsonObjectWithString:platTypesStr];
        }
        
        if (content)
        {
            NSString *contentStr = [NSString stringWithCString:content encoding:NSUTF8StringEncoding];
            contentObj = __getContentObjectWithString(contentStr);
        }
        
        [ShareSDK oneKeyShareContent:contentObj
                           shareList:platTypesArr
                         authOptions:nil
                        shareOptions:nil
                       statusBarTips:NO
                              result:^(ShareType type, SSResponseState state, id<ISSPlatformShareInfo> statusInfo, id<ICMErrorInfo> error, BOOL end) {
                                  
                                  NSMutableDictionary *resultDict = [NSMutableDictionary dictionary];
                                  [resultDict setObject:[NSNumber numberWithInteger:3] forKey:@"action"];
                                  [resultDict setObject:[NSNumber numberWithInteger:state] forKey:@"state"];
                                  [resultDict setObject:[NSNumber numberWithInteger:type] forKey:@"type"];
                                  [resultDict setObject:[NSNumber numberWithBool:end] forKey:@"end"];
                                  
                                  if (state == SSResponseStateFail && error)
                                  {
                                      NSMutableDictionary *errorDict = [NSMutableDictionary dictionary];
                                      [errorDict setObject:[NSNumber numberWithInteger:[error errorCode]] forKey:@"error_code"];
                                      if ([error errorDescription])
                                      {
                                          [errorDict setObject:[error errorDescription] forKey:@"error_msg"];
                                      }
                                      [resultDict setObject:errorDict forKey:@"error"];
                                  }
                                  else if ([statusInfo sourceData])
                                  {
                                      if (type == ShareTypeRenren)
                                      {
                                          [resultDict setObject:@{@"postid" : [statusInfo sourceData]}
                                                         forKey:@"share_info"];
                                      }
                                      else
                                      {
                                          [resultDict setObject:[statusInfo sourceData]
                                                         forKey:@"share_info"];
                                      }
                                  }
                                  
                                  NSString *resultStr = [ShareSDK jsonStringWithObject:resultDict];
                                  UnitySendMessage([observerStr UTF8String], "_callback", [resultStr UTF8String]);
                                  
                              }];
    }
    
    void __iosShareSDKShowShareMenu (void *platTypes, void *content, int x, int y, int direction, void *observer)
    {
        NSArray *platTypesArr = nil;
        NSString *observerStr = nil;
        id<ISSContent> contentObj = nil;
        
        observerStr = [NSString stringWithCString:observer encoding:NSUTF8StringEncoding];

        if (platTypes)
        {
            NSString *platTypesStr = [NSString stringWithCString:platTypes encoding:NSUTF8StringEncoding];
            platTypesArr = [ShareSDK jsonObjectWithString:platTypesStr];
        }
        
        if (content)
        {
            NSString *contentStr = [NSString stringWithCString:content encoding:NSUTF8StringEncoding];
            contentObj = __getContentObjectWithString(contentStr);
        }
        
        id<ISSContainer> container = nil;
        if ([UIDevice currentDevice].isPad)
        {
            if (!_refView)
            {
                _refView = [[UIView alloc] initWithFrame:CGRectMake(x, y, 1, 1)];
            }
            
            [[UIApplication sharedApplication].keyWindow addSubview:_refView];
            
            container = [ShareSDK container];
            [container setIPadContainerWithView:_refView arrowDirect:direction];
        }
        
        [ShareSDK showShareActionSheet:container
                             shareList:platTypesArr
                               content:contentObj
                         statusBarTips:NO
                           authOptions:nil
                          shareOptions:nil
                                result:^(ShareType type, SSResponseState state, id<ISSPlatformShareInfo> statusInfo, id<ICMErrorInfo> error, BOOL end) {
                                    
                                    NSMutableDictionary *resultDict = [NSMutableDictionary dictionary];
                                    [resultDict setObject:[NSNumber numberWithInteger:3] forKey:@"action"];
                                    [resultDict setObject:[NSNumber numberWithInteger:state] forKey:@"state"];
                                    [resultDict setObject:[NSNumber numberWithInteger:type] forKey:@"type"];
                                    [resultDict setObject:[NSNumber numberWithBool:end] forKey:@"end"];
                                    
                                    if (state == SSResponseStateFail && error)
                                    {
                                        NSMutableDictionary *errorDict = [NSMutableDictionary dictionary];
                                        [errorDict setObject:[NSNumber numberWithInteger:[error errorCode]] forKey:@"error_code"];
                                        if ([error errorDescription])
                                        {
                                            [errorDict setObject:[error errorDescription] forKey:@"error_msg"];
                                        }
                                        [resultDict setObject:errorDict forKey:@"error"];
                                    }
                                    else if ([statusInfo sourceData])
                                    {
                                        if (type == ShareTypeRenren)
                                        {
                                            [resultDict setObject:@{@"postid" : [statusInfo sourceData]}
                                                           forKey:@"share_info"];
                                        }
                                        else
                                        {
                                            [resultDict setObject:[statusInfo sourceData]
                                                           forKey:@"share_info"];
                                        }
                                    }
                                    
                                    NSString *resultStr = [ShareSDK jsonStringWithObject:resultDict];
                                    
                                    NSLog (@"callback = %@", resultStr);
                                    
                                    UnitySendMessage([observerStr UTF8String], "_callback", [resultStr UTF8String]);
                                    
                                    if (_refView)
                                    {
                                        //移除视图
                                        [_refView removeFromSuperview];
                                    }
                                }];
    }
    
    void __iosShareSDKShowShareView (int platType, void *content, void *observer)
    {
        NSString *observerStr = nil;
        id<ISSContent> contentObj = nil;
        
        observerStr = [NSString stringWithCString:observer encoding:NSUTF8StringEncoding];
        
        if (content)
        {
            NSString *contentStr = [NSString stringWithCString:content encoding:NSUTF8StringEncoding];
            contentObj = __getContentObjectWithString(contentStr);
        }
        
        [ShareSDK showShareViewWithType:platType
                              container:nil
                                content:contentObj
                          statusBarTips:NO
                            authOptions:nil
                           shareOptions:nil
                                 result:^(ShareType type, SSResponseState state, id<ISSPlatformShareInfo> statusInfo, id<ICMErrorInfo> error, BOOL end) {
                                     
                                     NSMutableDictionary *resultDict = [NSMutableDictionary dictionary];
                                     [resultDict setObject:[NSNumber numberWithInteger:3] forKey:@"action"];
                                     [resultDict setObject:[NSNumber numberWithInteger:state] forKey:@"state"];
                                     [resultDict setObject:[NSNumber numberWithInteger:type] forKey:@"type"];
                                     [resultDict setObject:[NSNumber numberWithBool:end] forKey:@"end"];
                                     
                                     if (state == SSResponseStateFail && error)
                                     {
                                         NSMutableDictionary *errorDict = [NSMutableDictionary dictionary];
                                         [errorDict setObject:[NSNumber numberWithInteger:[error errorCode]] forKey:@"error_code"];
                                         if ([error errorDescription])
                                         {
                                             [errorDict setObject:[error errorDescription] forKey:@"error_msg"];
                                         }
                                         [resultDict setObject:errorDict forKey:@"error"];
                                     }
                                     else if ([statusInfo sourceData])
                                     {
                                         if (type == ShareTypeRenren)
                                         {
                                             [resultDict setObject:@{@"postid" : [statusInfo sourceData]}
                                                            forKey:@"share_info"];
                                         }
                                         else
                                         {
                                             [resultDict setObject:[statusInfo sourceData]
                                                            forKey:@"share_info"];
                                         }
                                     }
                                     
                                     NSString *resultStr = [ShareSDK jsonStringWithObject:resultDict];
                                     UnitySendMessage([observerStr UTF8String], "_callback", [resultStr UTF8String]);
                                     
                                 }];
    }
    
#if defined (__cplusplus)
}
#endif

@implementation ShareSDKUnity3DBridge

@end
