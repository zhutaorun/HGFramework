//
//  UniWebView.mm
//  UniWebView
//
//  Created by 王 巍 on 14-12-19.
//  Copyright (c) 2013年 OneV's Den. All rights reserved.
//

#import <UIKit/UIKit.h>

#import "OrientationSupport.h"

#ifndef NSFoundationVersionNumber_iOS_7_1
#define NSFoundationVersionNumber_iOS_7_1 1047.25
#endif

#define BELOW_IOS_8 (NSFoundationVersionNumber <= NSFoundationVersionNumber_iOS_7_1)

extern UIViewController *UnityGetGLViewController();
extern ScreenOrientation UnityCurrentOrientation();
extern NSString * const kUnityViewWillRotate;

NSString * const UWVPlayerWillExitFullScreenNotification = @"UIMoviePlayerControllerWillExitFullscreenNotification";
NSString * const UWVPlayerDidEnterFullScreenNotification = @"UIMoviePlayerControllerDidEnterFullscreenNotification";

extern "C" void UnitySendMessage(const char *, const char *, const char *);

@interface UniWebViewToolBar : UIToolbar
@property (nonatomic, retain) UIBarButtonItem *btnNext;
@property (nonatomic, retain) UIBarButtonItem *btnBack;
@property (nonatomic, retain) UIBarButtonItem *btnReload;
@property (nonatomic, retain) UIBarButtonItem *btnDone;
@end

@implementation UniWebViewToolBar

@end

@interface UniWebSpinner : UIView
@property (nonatomic, retain) UIActivityIndicatorView *indicator;
@property (nonatomic, retain) UILabel *textLabel;
-(id) initWithFrame:(CGRect)frame;
-(void) show;
-(void) hide;
@end

@implementation UniWebSpinner
-(id) initWithFrame:(CGRect)frame {
    self = [super initWithFrame:frame];
    if (self) {
        self.backgroundColor = [UIColor colorWithRed:0 green:0 blue:0 alpha:0.5];
        self.clipsToBounds = YES;
        self.layer.cornerRadius = 10.0;

        _indicator = [[UIActivityIndicatorView alloc] initWithActivityIndicatorStyle:UIActivityIndicatorViewStyleWhiteLarge];

        _indicator.frame = (CGRect){ frame.size.width / 2 - _indicator.frame.size.width / 2,
                                    frame.size.height / 2 - _indicator.frame.size.height / 2 - 10,
                                    _indicator.bounds.size.width,
                                    _indicator.bounds.size.height};
        [self addSubview:_indicator];

        _textLabel = [[UILabel alloc] initWithFrame:CGRectMake(0, frame.size.height - 22 * 2, frame.size.width, 22)];
        _textLabel.backgroundColor = [UIColor clearColor];
        _textLabel.textColor = [UIColor whiteColor];
        _textLabel.adjustsFontSizeToFitWidth = YES;
        _textLabel.textAlignment = NSTextAlignmentCenter;
        _textLabel.text = @"Loading...";
        [self addSubview:_textLabel];

        UITapGestureRecognizer *tap = [[UITapGestureRecognizer alloc] initWithTarget:self action:@selector(hide)];
        [self addGestureRecognizer:tap];
    }
    return self;
}

-(void) show {
    self.hidden = NO;
    [self.indicator startAnimating];
}

-(void) hide {
    [self.indicator stopAnimating];
    self.hidden = YES;
}

@end

@class UniWebView;
@interface UniWebViewManager : NSObject
+ (UniWebViewManager *) sharedManager;
- (void)webViewDone:(UniWebView *)webView;
@end

@interface UniWebView : UIWebView
@property (nonatomic, retain) UniWebViewToolBar *toolBar;
@property (nonatomic, retain) UniWebSpinner *spinner;
@property (nonatomic, assign) UIEdgeInsets insets;

@property (nonatomic, assign) BOOL showSpinnerWhenLoading;
@property (nonatomic, copy) NSString *currentUrl;

@property (nonatomic, retain) NSMutableArray *schemes;

-(id) initWithFrame:(CGRect)frame;
-(void) btnDonePressed:(id)sender;
-(void) updateToolBtn;
-(void) changeToInsets:(UIEdgeInsets)insets targetOrientation:(ScreenOrientation)orientation;
-(void) setBounces:(BOOL)bounces;

@end

@interface NSUserDefaults(UnRegisterDefaults)
- (void)uwv_unregisterDefaultForKey:(NSString *)defaultName;
@end

@implementation NSUserDefaults (UnRegisterDefaults)

- (void)uwv_unregisterDefaultForKey:(NSString *)defaultName {
    NSDictionary *registeredDefaults = [[NSUserDefaults standardUserDefaults] volatileDomainForName:NSRegistrationDomain];
    if ([registeredDefaults objectForKey:defaultName] != nil) {
        NSMutableDictionary *mutableCopy = [NSMutableDictionary dictionaryWithDictionary:registeredDefaults];
        [mutableCopy removeObjectForKey:defaultName];
        [self uwv_replaceRegisteredDefaults:mutableCopy];
    }
}

- (void)uwv_replaceRegisteredDefaults:(NSDictionary *)dictionary {
    [[NSUserDefaults standardUserDefaults] setVolatileDomain:dictionary forName:NSRegistrationDomain];
}

@end

@implementation UniWebView
-(id) initWithFrame:(CGRect)frame {
    self = [super initWithFrame:frame];
    if (self) {
        CGRect toolBarFrame = CGRectMake(0, frame.size.height - 44, frame.size.width, 44);
        _toolBar = ({
            UniWebViewToolBar *toolBar = [[UniWebViewToolBar alloc] initWithFrame:toolBarFrame];

            UIBarButtonItem *back = [[UIBarButtonItem alloc] initWithBarButtonSystemItem:UIBarButtonSystemItemRewind target:self action:@selector(goBack)];
            UIBarButtonItem *forward = [[UIBarButtonItem alloc] initWithBarButtonSystemItem:UIBarButtonSystemItemFastForward target:self action:@selector(goForward)];
            UIBarButtonItem *reload = [[UIBarButtonItem alloc] initWithBarButtonSystemItem:UIBarButtonSystemItemRefresh target:self action:@selector(btnReloadPressed:)];
            UIBarButtonItem *space = [[UIBarButtonItem alloc] initWithBarButtonSystemItem:UIBarButtonSystemItemFlexibleSpace target:self action:nil];
            UIBarButtonItem *done = [[UIBarButtonItem alloc] initWithBarButtonSystemItem:UIBarButtonSystemItemDone target:self action:@selector(btnDonePressed:)];

            toolBar.items = @[back,forward,reload,space,done];

            toolBar.btnBack = back;
            toolBar.btnNext = forward;
            toolBar.btnReload = reload;
            toolBar.btnDone = done;

            toolBar.hidden = YES;

            toolBar;
        });

        _schemes = [[NSMutableArray alloc] initWithObjects:@"uniwebview", nil];

        _showSpinnerWhenLoading = YES;

        _spinner = ({
            UniWebSpinner *spinner = [[UniWebSpinner alloc] initWithFrame:CGRectMake(frame.size.width / 2 - 65, frame.size.height / 2 - 65, 130, 130)];
            [spinner hide];
            spinner;
        });

        [self setBounces:NO];
        [self updateToolBtn];

    }
    return self;
}

-(void)setBounces:(BOOL)bounces {
    UIScrollView* sv = nil;
    for(UIView* view in self.subviews){
        if([view isKindOfClass:[UIScrollView class]]){
            sv = (UIScrollView*)view;
            sv.bounces = bounces;
        }
    }
}

-(void) btnDonePressed:(id)sender {
    [[UniWebViewManager sharedManager] webViewDone:self];
}

-(void) btnReloadPressed:(id)sender {
    if (!self.loading) {
        [self reload];
    } else {
        NSLog(@"UniWebView can not reload because some content is being loading right now.");
    }
}

-(void) updateToolBtn {
    self.toolBar.btnBack.enabled = [self canGoBack];
    self.toolBar.btnNext.enabled = [self canGoForward];
}

-(void)changeToInsets:(UIEdgeInsets)insets targetOrientation:(ScreenOrientation)orientation {
    UIView *unityView = UnityGetGLViewController().view;
    CGRect viewRect = unityView.frame;

    if (orientation == landscapeLeft || orientation == landscapeRight) {
        if (BELOW_IOS_8) {
            viewRect = CGRectMake(viewRect.origin.x, viewRect.origin.y, viewRect.size.height, viewRect.size.width);
            self.toolBar.frame = CGRectMake(0, unityView.frame.size.width - 44, unityView.frame.size.height, 44);
            self.spinner.frame = CGRectMake(unityView.frame.size.height / 2 - 65, unityView.frame.size.width / 2 - 65, 130, 130);
        } else {
            self.toolBar.frame = CGRectMake(0, unityView.frame.size.height - 44, unityView.frame.size.width, 44);
            self.spinner.frame = CGRectMake(unityView.frame.size.width / 2 - 65, unityView.frame.size.height / 2 - 65, 130, 130);
        }
    } else {
        self.toolBar.frame = CGRectMake(0, unityView.frame.size.height - 44, unityView.frame.size.width, 44);
        self.spinner.frame = CGRectMake(unityView.frame.size.width / 2 - 65, unityView.frame.size.height / 2 - 65, 130, 130);
    }

    CGRect f = CGRectMake(insets.left,
                          insets.top,
                          viewRect.size.width - insets.left - insets.right,
                          viewRect.size.height - insets.top - insets.bottom);
    self.frame = f;
    self.insets = insets;
}

@end

@interface UniWebViewManager()<UIWebViewDelegate> {
    NSMutableDictionary *_webViewDic;
    ScreenOrientation _orientationBeforeFullScreen;
    BOOL _multipleOrientation;
}
@end

@implementation UniWebViewManager
+ (UniWebViewManager *) sharedManager {
    static dispatch_once_t once;
    static UniWebViewManager *instance;
    dispatch_once(&once, ^ { instance = [[UniWebViewManager alloc] init]; });
    return instance;
}

-(instancetype) init {
    self = [super init];
    if (self) {
        _webViewDic = [[NSMutableDictionary alloc] init];
        [[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(videoExitFullScreen:) name:UWVPlayerWillExitFullScreenNotification object:nil];
        [[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(videoEnterFullScreen:) name:UWVPlayerDidEnterFullScreenNotification object:nil];
        
        [self checkOrientationSupport];
    }
    return self;
}

-(void) checkOrientationSupport {
    NSArray *arr = [[[NSBundle mainBundle] infoDictionary] objectForKey:@"UISupportedInterfaceOrientations"];
    __block BOOL portraitOrientation = NO;
    __block BOOL landspaceOrientation = NO;
    
    [arr enumerateObjectsUsingBlock:^(NSString *orientation, NSUInteger idx, BOOL *stop) {
        if ([orientation rangeOfString:@"Portrait"].location != NSNotFound) {
            portraitOrientation = YES;
        } else if ([orientation rangeOfString:@"Landscape"].location != NSNotFound) {
            landspaceOrientation = YES;
        }
        
        if (portraitOrientation && landspaceOrientation) {
            _multipleOrientation = YES;
            *stop = YES;
        }
    }];
}

-(void) addManagedWebView:(UniWebView *)webView forName:(NSString *)name {
    if (![_webViewDic objectForKey:name]) {
        [_webViewDic setObject:webView forKey:name];
    } else {
        NSLog(@"Duplicated name. Something goes wrong: %@", name);
    }
}

-(void) addManagedWebViewName:(NSString *)name insets:(UIEdgeInsets)insets {
    UIView *unityView = UnityGetGLViewController().view;
    UniWebView *webView = [[UniWebView alloc] initWithFrame:unityView.frame];
    webView.mediaPlaybackRequiresUserAction = NO;

    [self changeWebView:webView insets:insets];
    webView.delegate = self;
    webView.hidden = YES;

    [self addManagedWebView:webView forName:name];
    [unityView addSubview:webView];
    [unityView addSubview:webView.toolBar];
    [unityView addSubview:webView.spinner];
}

-(void) changeWebViewName:(NSString *)name insets:(UIEdgeInsets)insets {
    UniWebView *webView = [_webViewDic objectForKey:name];
    [self changeWebView:webView insets:insets];
}

-(void) changeWebView:(UniWebView *)webView insets:(UIEdgeInsets)insets {
    [webView changeToInsets:insets targetOrientation:UnityCurrentOrientation()];
}

-(void) webviewName:(NSString *)name beginLoadURL:(NSString *)urlString {
    UniWebView *webView = [_webViewDic objectForKey:name];
    NSURL *url = [NSURL URLWithString:urlString];
    NSURLRequest *request = [NSURLRequest requestWithURL:url];

    [webView loadRequest:request];
}

-(void) webViewNameReload:(NSString *)name {
    UniWebView *webView = [_webViewDic objectForKey:name];
    [webView reload];
}

-(void) webViewNameStop:(NSString *)name {
    UniWebView *webView = [_webViewDic objectForKey:name];
    if ([webView isLoading]) {
        [webView stopLoading];
    }
}

-(void) webViewNameCleanCache:(NSString *)name {
    UniWebView *webView = [_webViewDic objectForKey:name];
    [[NSURLCache sharedURLCache] removeCachedResponseForRequest:webView.request];

    [[NSURLCache sharedURLCache] removeAllCachedResponses];
}

-(void) webViewNameCleanCookie:(NSString *)name forKey:(NSString *)key {
    
    NSHTTPCookie *cookie;
    NSHTTPCookieStorage *cookieJar = [NSHTTPCookieStorage sharedHTTPCookieStorage];
    
    if (key.length) {
        NSLog(@"Removing cookie for %@", key);
        for (cookie in [cookieJar cookies]) {
            if ([cookie.name isEqualToString:key]) {
                [cookieJar deleteCookie:cookie];
                NSLog(@"Found cookie for %@, removed.", key);
            }
        }
    } else {
        NSLog(@"Removing all cookies");
        for (cookie in [cookieJar cookies]) {
            [cookieJar deleteCookie:cookie];
        }
    }
    
    [[NSUserDefaults standardUserDefaults] synchronize];
}

-(void) webViewName:(NSString *)name show:(BOOL)show {
    UniWebView *webView = [_webViewDic objectForKey:name];
    webView.hidden = !show;
}

-(void) removeWebViewName:(NSString *)name {
    UniWebView *webView = [_webViewDic objectForKey:name];
    webView.delegate = nil;
    [webView removeFromSuperview];
    [webView.toolBar removeFromSuperview];
    [_webViewDic removeObjectForKey:name];

}

-(void) updateBackgroundWebViewName:(NSString *)name transparent:(BOOL)transparent {
    UniWebView *webView = [_webViewDic objectForKey:name];
    webView.opaque = !transparent;
    webView.backgroundColor = transparent ? [UIColor clearColor] : [UIColor whiteColor];
    for (UIView* subView in [webView subviews]) {
        if ([subView isKindOfClass:[UIScrollView class]]) {
            for (UIView* shadowView in [subView subviews]) {
                if ([shadowView isKindOfClass:[UIImageView class]]) {
                    [shadowView setHidden:transparent];
                }
            }
        }
    }
}

-(void) webViewName:(NSString *)name showToolBarAnimate:(BOOL)animate {
    UniWebView *webView = [_webViewDic objectForKey:name];
    if (webView.toolBar.hidden) {
        if (animate) {
            CGRect oldFrame = webView.toolBar.frame;
            webView.toolBar.frame = CGRectOffset(oldFrame, 0, oldFrame.size.height);
            webView.toolBar.hidden = NO;
            [UIView animateWithDuration:0.4 animations:^{
                webView.toolBar.frame = oldFrame;
            }];
        } else {
            webView.toolBar.hidden = NO;
        }
    }
}

-(void) webViewName:(NSString *)name hideToolBarAnimate:(BOOL)animate {
    UniWebView *webView = [_webViewDic objectForKey:name];
    if (!webView.toolBar.hidden) {
        if (animate) {
            CGRect oldFrame = webView.toolBar.frame;
            [UIView animateWithDuration:0.4 animations:^{
                webView.toolBar.frame = CGRectOffset(oldFrame, 0, oldFrame.size.height);
            } completion:^(BOOL finished) {
                webView.toolBar.hidden = YES;
                webView.toolBar.frame = oldFrame;
            }];
        } else {
            webView.toolBar.hidden = YES;
        }
    }
}

-(void) goBackWebViewName:(NSString *)name {
    UniWebView *webView = [_webViewDic objectForKey:name];
    [webView goBack];
}

-(void) goForwardWebViewName:(NSString *)name {
    UniWebView *webView = [_webViewDic objectForKey:name];
    [webView goForward];
}

-(void) webViewName:(NSString *)name setZoomEnable:(BOOL)enable {
    UniWebView *webView = [_webViewDic objectForKey:name];
    webView.scalesPageToFit = enable;
}

-(void) webViewName:(NSString *)name setBounces:(BOOL)bounces {
    UniWebView *webView = [_webViewDic objectForKey:name];
    [webView setBounces:bounces];
}

-(void) webViewName:(NSString *)name loadHTMLString:(NSString *)htmlString baseURLString:(NSString *)baseURL {
    UniWebView *webView = [_webViewDic objectForKey:name];
    [webView loadHTMLString:htmlString baseURL:[NSURL URLWithString:baseURL]];
}

-(void) webViewName:(NSString *)name evaluatingJavaScript:(NSString *)javaScript shouldCallBack:(BOOL)callBack {
    UniWebView *webView = [_webViewDic objectForKey:name];
    NSString *result = [webView stringByEvaluatingJavaScriptFromString:javaScript];
    if (callBack) {
        UnitySendMessage([name UTF8String], "EvalJavaScriptFinished", [result UTF8String]);    
    }
}

-(void) webViewName:(NSString *)name setSpinnerShowWhenLoading:(BOOL)show {
    UniWebView *webView = [_webViewDic objectForKey:name];
    webView.showSpinnerWhenLoading = show;
}

-(void) webViewName:(NSString *)name setSpinnerText:(NSString *)text {
    UniWebView *webView = [_webViewDic objectForKey:name];
    if (text) {
        webView.spinner.textLabel.text = text;
    }
}

-(NSString *) webViewName:(UniWebView *)webView {
    NSString *webViewName = [[_webViewDic allKeysForObject:webView] lastObject];
    if (!webViewName) {
        NSLog(@"Did not find the webview: %@",webViewName);
    }
    return webViewName;
}

- (void)webViewName:(NSString *)name addUrlScheme:(NSString *)scheme {
    UniWebView *webView = [_webViewDic objectForKey:name];
    if (![webView.schemes containsObject:scheme]) {
        [webView.schemes addObject:scheme];
    }
}

- (void)webViewName:(NSString *)name removeUrlScheme:(NSString *)scheme {
    UniWebView *webView = [_webViewDic objectForKey:name];
    if ([webView.schemes containsObject:scheme]) {
        [webView.schemes removeObject:scheme];
    }
}

- (void)webViewDidStartLoad:(UniWebView *)webView {
    if (webView.showSpinnerWhenLoading && !webView.hidden) {
        [webView.spinner show];
    }
}

- (void)webViewDidFinishLoad:(UniWebView *)webView {
    [webView.spinner hide];
    NSString *webViewName = [self webViewName:webView];
    [webView updateToolBtn];

    webView.currentUrl = webView.request.mainDocumentURL.absoluteString;
    UnitySendMessage([webViewName UTF8String], "LoadComplete", "");
}

- (void)webView:(UniWebView *)webView didFailLoadWithError:(NSError *)error {
    [webView.spinner hide];
    NSString *webViewName = [self webViewName:webView];
    [webView updateToolBtn];

    webView.currentUrl = webView.request.mainDocumentURL.absoluteString;
    UnitySendMessage([webViewName UTF8String], "LoadComplete", [error.localizedDescription UTF8String]);
}

- (void)webViewDone:(UniWebView *)webView {
    [webView.spinner hide];
    NSString *webViewName = [self webViewName:webView];
    UnitySendMessage([webViewName UTF8String], "WebViewDone", "");
}

-(NSString *) webViewNameGetCurrentUrl:(NSString *)name {
    UniWebView *webView = [_webViewDic objectForKey:name];
    return webView.currentUrl ?: @"";
}

-(BOOL)webView:(UniWebView *)webView shouldStartLoadWithRequest:(NSURLRequest *)request navigationType:(UIWebViewNavigationType)navigationType {
    NSString *webViewName = [self webViewName:webView];

    __block BOOL canResponse = NO;
    [webView.schemes enumerateObjectsUsingBlock:^(NSString *scheme, NSUInteger idx, BOOL *stop) {
        if ([[request.URL absoluteString] rangeOfString:[scheme stringByAppendingString:@"://"]].location == 0) {
            canResponse = YES;
            *stop = YES;
        }
    }];

    if (canResponse) {
        NSString *rawMessage = [NSString stringWithFormat:@"%@",request.URL];
        UnitySendMessage([webViewName UTF8String], "ReceivedMessage", [rawMessage UTF8String]);
        return NO;
    } else {
        UnitySendMessage([webViewName UTF8String], "LoadBegin", [request.URL.absoluteString UTF8String]);
    }
    return YES;
}

-(void) videoEnterFullScreen:(NSNotification *)noti {
    UIInterfaceOrientation toInterfaceOrientation = [UIApplication sharedApplication].statusBarOrientation;
    _orientationBeforeFullScreen = ConvertToUnityScreenOrientation(toInterfaceOrientation);
}

-(void) videoExitFullScreen:(NSNotification *)noti {
    
    ScreenOrientation orientation = portrait;
    
    if (_multipleOrientation) {
        UIInterfaceOrientation toInterfaceOrientation = [UIApplication sharedApplication].statusBarOrientation;
        orientation = ConvertToUnityScreenOrientation(toInterfaceOrientation);
    } else {
        orientation = UnityCurrentOrientation();
    }
    
    if (_orientationBeforeFullScreen == landscapeLeft || _orientationBeforeFullScreen == landscapeRight) {
        if (orientation == portrait) {
            orientation = _orientationBeforeFullScreen;
        } else {
            orientation = portrait;
        }
    }
    
    [_webViewDic enumerateKeysAndObjectsUsingBlock:^(id key, id obj, BOOL *stop) {
        UniWebView *webView = (UniWebView *)obj;
        [webView changeToInsets:webView.insets targetOrientation:orientation];
    }];
}

-(NSString *) webViewGetUserAgent:(NSString *)name {
    UniWebView *webView = [_webViewDic objectForKey:name];
    return [webView stringByEvaluatingJavaScriptFromString:@"window.navigator.userAgent"];
}

-(void) webViewSetUserAgent:(NSString *)userAgent {
    [[NSUserDefaults standardUserDefaults] uwv_unregisterDefaultForKey:@"UserAgent"];
    
    if (userAgent.length != 0) {
        NSDictionary *dictionary = [NSDictionary dictionaryWithObjectsAndKeys:userAgent, @"UserAgent", nil];
        [[NSUserDefaults standardUserDefaults] registerDefaults:dictionary];
    }
}
@end


// Helper method to create C string copy
NSString* UniWebViewMakeNSString (const char* string) {
    if (string) {
        return [NSString stringWithUTF8String: string];
    } else {
        return [NSString stringWithUTF8String: ""];
    }
}

char* UniWebViewMakeCString(NSString *str) {
    const char* string = [str UTF8String];
    if (string == NULL) {
        return NULL;
    }

    char* res = (char*)malloc(strlen(string) + 1);
    strcpy(res, string);
    return res;
}

extern "C" {
    void _UniWebViewInit(const char *name, int top, int left, int bottom, int right);
    void _UniWebViewChangeSize(const char *name, int top, int left, int bottom, int right);
    void _UniWebViewLoad(const char *name, const char *url);
    void _UniWebViewReload(const char *name);
    void _UniWebViewStop(const char *name);
    void _UniWebViewShow(const char *name);
    void _UniWebViewDismiss(const char *name);
    void _UniWebViewCleanCache(const char *name);
    void _UniWebViewCleanCookie(const char *name, const char *key);
    void _UniWebViewDestroy(const char *name);
    void _UniWebViewTransparentBackground(const char *name, BOOL transparent);
    void _UniWebViewShowToolBar(const char *name, bool animate);
    void _UniWebViewHideToolBar(const char *name, bool animate);
    void _UniWebViewGoBack(const char *name);
    void _UniWebViewGoForward(const char *name);
    void _UniWebViewLoadHTMLString(const char *name, const char *html, const char *baseUrl);
    void _UniWebViewEvaluatingJavaScript(const char *name, const char *javascript, BOOL callback);
    void _UniWebViewSetSpinnerShowWhenLoading(const char *name, bool show);
    void _UniWebViewSetSpinnerText(const char *name, const char *text);
    const char * _UniWebViewGetCurrentUrl(const char *name);
    void _UniWebViewSetBounces(const char *name, bool bounces);
    void _UniWebViewSetZoomEnable(const char *name, bool enable);
    void _UniWebViewAddUrlScheme(const char *name, const char *scheme);
    void _UniWebViewRemoveUrlScheme(const char *name, const char *scheme);
    int _UniWebViewScreenHeight();
    int _UniWebViewScreenWidth();
    const char * _UniWebViewGetUserAgent(const char *name);
    void _UniWebViewSetUserAgent(const char *userAgent);
    
}

void _UniWebViewInit(const char *name, int top, int left, int bottom, int right) {
    UIEdgeInsets insets = UIEdgeInsetsMake(top, left, bottom, right);
    [[UniWebViewManager sharedManager] addManagedWebViewName:UniWebViewMakeNSString(name) insets:insets];
}

void _UniWebViewChangeSize(const char *name, int top, int left, int bottom, int right) {
    UIEdgeInsets insets = UIEdgeInsetsMake(top, left, bottom, right);
    [[UniWebViewManager sharedManager] changeWebViewName:UniWebViewMakeNSString(name) insets:insets];
}

void _UniWebViewLoad(const char *name, const char *url) {
    [[UniWebViewManager sharedManager] webviewName:UniWebViewMakeNSString(name)
                                      beginLoadURL:UniWebViewMakeNSString(url)];
}

void _UniWebViewReload(const char *name) {
    [[UniWebViewManager sharedManager] webViewNameReload:UniWebViewMakeNSString(name)];
}

void _UniWebViewStop(const char *name) {
    [[UniWebViewManager sharedManager] webViewNameStop:UniWebViewMakeNSString(name)];
}

void _UniWebViewShow(const char *name) {
    [[UniWebViewManager sharedManager] webViewName:UniWebViewMakeNSString(name) show:YES];
}

void _UniWebViewDismiss(const char *name) {
    [[UniWebViewManager sharedManager] webViewName:UniWebViewMakeNSString(name) show:NO];
}

void _UniWebViewCleanCache(const char *name) {
    [[UniWebViewManager sharedManager] webViewNameCleanCache:UniWebViewMakeNSString(name)];
}

void _UniWebViewCleanCookie(const char *name, const char *key) {
    [[UniWebViewManager sharedManager] webViewNameCleanCookie:UniWebViewMakeNSString(name) forKey:UniWebViewMakeNSString(key)];
}

void _UniWebViewDestroy(const char *name) {
    [[UniWebViewManager sharedManager] removeWebViewName:UniWebViewMakeNSString(name)];
}

void _UniWebViewTransparentBackground(const char *name, BOOL transparent) {
    [[UniWebViewManager sharedManager] updateBackgroundWebViewName:UniWebViewMakeNSString(name) transparent:transparent];
}

void _UniWebViewShowToolBar(const char *name, bool animate) {
    [[UniWebViewManager sharedManager] webViewName:UniWebViewMakeNSString(name) showToolBarAnimate:animate];
}
void _UniWebViewHideToolBar(const char *name, bool animate) {
    [[UniWebViewManager sharedManager] webViewName:UniWebViewMakeNSString(name) hideToolBarAnimate:animate];
}

void _UniWebViewGoBack(const char *name) {
    [[UniWebViewManager sharedManager] goBackWebViewName:UniWebViewMakeNSString(name)];
}

void _UniWebViewGoForward(const char *name) {
    [[UniWebViewManager sharedManager] goForwardWebViewName:UniWebViewMakeNSString(name)];
}

void _UniWebViewLoadHTMLString(const char *name, const char *html, const char *baseUrl) {
    [[UniWebViewManager sharedManager] webViewName:UniWebViewMakeNSString(name)
                                    loadHTMLString:UniWebViewMakeNSString(html)
                                     baseURLString:UniWebViewMakeNSString(baseUrl)];
}

void _UniWebViewSetBounces(const char *name, bool bounces) {
    [[UniWebViewManager sharedManager] webViewName:UniWebViewMakeNSString(name) setBounces:bounces];
}

void _UniWebViewEvaluatingJavaScript(const char *name, const char *javascript, BOOL callback) {
    NSString *webViewName = UniWebViewMakeNSString(name);
    NSString *jsString = UniWebViewMakeNSString(javascript);
    NSLog(@"webViewName:%@, eval js:%@",webViewName,jsString);
    [[UniWebViewManager sharedManager] webViewName:webViewName evaluatingJavaScript:jsString shouldCallBack:callback];
}

void _UniWebViewSetSpinnerShowWhenLoading(const char *name, bool show) {
    [[UniWebViewManager sharedManager] webViewName:UniWebViewMakeNSString(name)
                         setSpinnerShowWhenLoading:show];
}

void _UniWebViewSetSpinnerText(const char *name, const char *text) {
    [[UniWebViewManager sharedManager] webViewName:UniWebViewMakeNSString(name)
                                    setSpinnerText:UniWebViewMakeNSString(text)];
}

const char *_UniWebViewGetCurrentUrl(const char *name) {
    return UniWebViewMakeCString([[UniWebViewManager sharedManager] webViewNameGetCurrentUrl:UniWebViewMakeNSString(name)]);
}

void _UniWebViewSetZoomEnable(const char *name, bool enable) {
    [[UniWebViewManager sharedManager] webViewName:UniWebViewMakeNSString(name) setZoomEnable:enable];
}

void _UniWebViewAddUrlScheme(const char *name, const char *scheme) {
    [[UniWebViewManager sharedManager] webViewName:UniWebViewMakeNSString(name)
                                      addUrlScheme:UniWebViewMakeNSString(scheme)];
}

void _UniWebViewRemoveUrlScheme(const char *name, const char *scheme) {
    [[UniWebViewManager sharedManager] webViewName:UniWebViewMakeNSString(name)
                                   removeUrlScheme:UniWebViewMakeNSString(scheme)];
}

int _UniWebViewScreenHeight() {
    if (BELOW_IOS_8) {
        if (UnityCurrentOrientation() == landscapeLeft || UnityCurrentOrientation() == landscapeRight) {
            return UnityGetGLViewController().view.frame.size.width;
        } else {
            return UnityGetGLViewController().view.frame.size.height;
        }
    } else {
        return UnityGetGLViewController().view.frame.size.height;
    }
}

int _UniWebViewScreenWidth() {
    if (BELOW_IOS_8) {
        if (UnityCurrentOrientation() == landscapeLeft || UnityCurrentOrientation() == landscapeRight) {
            return UnityGetGLViewController().view.frame.size.height;
        } else {
            return UnityGetGLViewController().view.frame.size.width;
        }
    } else {
        return UnityGetGLViewController().view.frame.size.width;
    }
}

const char * _UniWebViewGetUserAgent(const char *name) {
    return UniWebViewMakeCString([[UniWebViewManager sharedManager] webViewGetUserAgent:UniWebViewMakeNSString(name)]);
}

void _UniWebViewSetUserAgent(const char *userAgent) {
    [[UniWebViewManager sharedManager] webViewSetUserAgent:UniWebViewMakeNSString(userAgent)];
}
