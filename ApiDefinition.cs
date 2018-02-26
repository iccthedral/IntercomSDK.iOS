using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace IntercomSDK
{
    // @interface Intercom : NSObject
    [BaseType(typeof(NSObject))]
    interface Intercom
    {
        // +(void)setApiKey:(NSString *)apiKey forAppId:(NSString *)appId;
        [Static]
        [Export("setApiKey:forAppId:")]
        void SetApiKey(string apiKey, string appId);

        // +(void)setUserHash:(NSString *)userHash;
        [Static]
        [Export("setUserHash:")]
        void SetUserHash(string hmac);

        // +(void)registerUnidentifiedUser;
        [Static]
        [Export("registerUnidentifiedUser")]
        void RegisterUnidentifiedUser();

        // +(void)registerUserWithUserId:(NSString *)userId email:(NSString *)email;
        [Static]
        [Export("registerUserWithUserId:email:")]
        void RegisterUserWithUserId(string userId, string email);

        // +(void)registerUserWithUserId:(NSString *)userId;
        [Static]
        [Export("registerUserWithUserId:")]
        void RegisterUserWithUserId(string userId);

        // +(void)registerUserWithEmail:(NSString *)email;
        [Static]
        [Export("registerUserWithEmail:")]
        void RegisterUserWithEmail(string email);

        // + (void)logout;
        [Static]
        [Export("logout")]
        void Logout();

        // +(void)updateUserWithAttributes:(NSDictionary *)attributes;
        [Static]
        [Export("updateUserWithAttributes:")]
        void UpdateUserWithAttributes(NSDictionary attributes);

        // +(void)logEventWithName:(NSString *)name;
        [Static]
        [Export("logEventWithName:")]
        void LogEventWithName(string name);

        // +(void)logEventWithName:(NSString *)name metaData:(NSDictionary *)metaData;
        [Static]
        [Export("logEventWithName:metaData:")]
        void LogEventWithName(string name, NSDictionary metaData);

        // +(void)presentMessenger;
        [Static]
        [Export("presentMessenger")]
        void PresentMessenger();

        // +(void)presentMessageComposer;
        [Static]
        [Export("presentMessageComposer")]
        void PresentMessageComposer();

        // +(void)presentMessageComposerWithInitialMessage:(NSString *)message;
        [Static]
        [Export("presentMessageComposerWithInitialMessage:")]
        void PresentMessageComposerWithInitialMessage(string message);

        // +(void)presentConversationList;
        [Static]
        [Export("presentConversationList")]
        void PresentConversationList();

        // +(void)presentHelpCenter;
        [Static]
        [Export("presentHelpCenter")]
        void PresentHelpCenter();

        // +(void)setDeviceToken:(NSData *)deviceToken;
        [Static]
        [Export("setDeviceToken:")]
        void SetDeviceToken(NSData deviceToken);

        // +(BOOL)isIntercomPushNotification:(NSDictionary*) userInfo;
        [Static]
        [Export("isIntercomPushNotification:")]
        bool IsIntercomPushNotification(NSDictionary userInfo);

        // +(void)handleIntercomPushNotification:(NSDictionary *)userInfo;
        [Static]
        [Export("handleIntercomPushNotification:")]
        void HandleIntercomPushNotification(NSDictionary userInfo);

        // +(void)setBottomPadding:(CGFloat)bottomPadding;
        [Static]
        [Export("setBottomPadding:")]
        void SetBottomPadding(nfloat bottomPadding);

        // +(void)setInAppMessagesVisible:(BOOL)visible;
        [Static]
        [Export("setInAppMessagesVisible:")]
        void SetInAppMessagesVisible(bool visible);

        // +(void)setLauncherVisible:(BOOL)visible;
        [Static]
        [Export("setLauncherVisible:")]
        void SetLauncherVisible(bool visible);

        // +(void)hideMessenger;
        [Static]
        [Export("hideMessenger")]
        void HideMessenger();

        // +(NSUInteger)unreadConversationCount;
        [Static]
        [Export("unreadConversationCount")]
        //[Verify(MethodToProperty)]
        nuint UnreadConversationCount();

        // +(void)enableLogging;
        [Static]
        [Export("enableLogging")]
        void EnableLogging();

        // +(void)setNeedsStatusBarAppearanceUpdate;
        [Static]
        [Export("setNeedsStatusBarAppearanceUpdate")]
        void SetNeedsStatusBarAppearanceUpdate();

        // extern NSString *const IntercomUnreadConversationCountDidChangeNotification __attribute__((visibility("default")));
        [Notification]
        [Field("IntercomUnreadConversationCountDidChangeNotification", "__Internal")]
        NSString IntercomUnreadConversationCountDidChangeNotification { get; }

        // extern NSString *const IntercomWindowWillShowNotification __attribute__((visibility("default")));
        [Notification]
        [Field("IntercomWindowWillShowNotification", "__Internal")]
        NSString IntercomWindowWillShowNotification { get; }

        // extern NSString *const IntercomWindowDidShowNotification __attribute__((visibility("default")));
        [Notification]
        [Field("IntercomWindowDidShowNotification", "__Internal")]
        NSString IntercomWindowDidShowNotification { get; }

        // extern NSString *const IntercomWindowWillHideNotification __attribute__((visibility("default")));
        [Notification]
        [Field("IntercomWindowWillHideNotification", "__Internal")]
        NSString IntercomWindowWillHideNotification { get; }

        // extern NSString *const IntercomWindowDidHideNotification __attribute__((visibility("default")));
        [Notification]
        [Field("IntercomWindowDidHideNotification", "__Internal")]
        NSString IntercomWindowDidHideNotification { get; }

        // extern NSString *const IntercomDidStartNewConversationNotification __attribute__((visibility("default")));
        [Notification]
        [Field("IntercomDidStartNewConversationNotification", "__Internal")]
        NSString IntercomDidStartNewConversationNotification { get; }
    }
}