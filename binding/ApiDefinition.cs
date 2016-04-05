using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MonoTouch.Mixpanel
{
    // @interface Mixpanel : NSObject
    [BaseType (typeof(NSObject))]
    interface Mixpanel
    {
        // @property (readonly, atomic, strong) MixpanelPeople * people;
        [Export ("people", ArgumentSemantic.Strong)]
        MixpanelPeople People { get; }

        // @property (readonly, copy, atomic) NSString * distinctId;
        [Export ("distinctId")]
        string DistinctId { get; }

        // @property (copy, atomic) NSString * nameTag;
        [Export ("nameTag")]
        string NameTag { get; set; }

        // @property (copy, atomic) NSString * serverURL;
        [Export ("serverURL")]
        string ServerURL { get; set; }

        // @property (atomic) NSUInteger flushInterval;
        [Export ("flushInterval")]
        nuint FlushInterval { get; set; }

        // @property (atomic) BOOL flushOnBackground;
        [Export ("flushOnBackground")]
        bool FlushOnBackground { get; set; }

        // @property (atomic) BOOL showNetworkActivityIndicator;
        [Export ("showNetworkActivityIndicator")]
        bool ShowNetworkActivityIndicator { get; set; }

        // @property (atomic) BOOL checkForSurveysOnActive;
        [Export ("checkForSurveysOnActive")]
        bool CheckForSurveysOnActive { get; set; }

        // @property (atomic) BOOL showSurveyOnActive;
        [Export ("showSurveyOnActive")]
        bool ShowSurveyOnActive { get; set; }

        // @property (atomic) BOOL checkForNotificationsOnActive;
        [Export ("checkForNotificationsOnActive")]
        bool CheckForNotificationsOnActive { get; set; }

        // @property (atomic) BOOL checkForVariantsOnActive;
        [Export ("checkForVariantsOnActive")]
        bool CheckForVariantsOnActive { get; set; }

        // @property (atomic) BOOL showNotificationOnActive;
        [Export ("showNotificationOnActive")]
        bool ShowNotificationOnActive { get; set; }

        // @property (atomic) CGFloat miniNotificationPresentationTime;
        [Export ("miniNotificationPresentationTime")]
        nfloat MiniNotificationPresentationTime { get; set; }

        // @property (atomic) UIColor * miniNotificationBackgroundColor;
        [Export ("miniNotificationBackgroundColor", ArgumentSemantic.Assign)]
        UIColor MiniNotificationBackgroundColor { get; set; }

        [Wrap ("WeakDelegate")]
        [NullAllowed]
        MixpanelDelegate Delegate { get; set; }

        // @property (atomic, weak) id<MixpanelDelegate> _Nullable delegate;
        [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // +(Mixpanel *)sharedInstanceWithToken:(NSString *)apiToken;
        [Static]
        [Export ("sharedInstanceWithToken:")]
        Mixpanel SharedInstanceWithToken (string apiToken);

        // +(Mixpanel *)sharedInstanceWithToken:(NSString *)apiToken launchOptions:(NSDictionary *)launchOptions;
        [Static]
        [Export ("sharedInstanceWithToken:launchOptions:")]
        Mixpanel SharedInstanceWithToken (string apiToken, NSDictionary launchOptions);

        // +(Mixpanel *)sharedInstance;
        [Static]
        [Export ("sharedInstance")]
        Mixpanel SharedInstance { get; }

        // -(instancetype)initWithToken:(NSString *)apiToken launchOptions:(NSDictionary *)launchOptions andFlushInterval:(NSUInteger)flushInterval;
        [Export ("initWithToken:launchOptions:andFlushInterval:")]
        IntPtr Constructor (string apiToken, NSDictionary launchOptions, nuint flushInterval);

        // -(instancetype)initWithToken:(NSString *)apiToken andFlushInterval:(NSUInteger)flushInterval;
        [Export ("initWithToken:andFlushInterval:")]
        IntPtr Constructor (string apiToken, nuint flushInterval);

        // -(void)identify:(NSString *)distinctId;
        [Export ("identify:")]
        void Identify (string distinctId);

        // -(void)track:(NSString *)event;
        [Export ("track:")]
        void Track (string @event);

        // -(void)track:(NSString *)event properties:(NSDictionary *)properties;
        [Export ("track:properties:")]
        void Track (string @event, NSDictionary properties);

        // -(void)trackPushNotification:(NSDictionary *)userInfo;
        [Export ("trackPushNotification:")]
        void TrackPushNotification (NSDictionary userInfo);

        // -(void)registerSuperProperties:(NSDictionary *)properties;
        [Export ("registerSuperProperties:")]
        void RegisterSuperProperties (NSDictionary properties);

        // -(void)registerSuperPropertiesOnce:(NSDictionary *)properties;
        [Export ("registerSuperPropertiesOnce:")]
        void RegisterSuperPropertiesOnce (NSDictionary properties);

        // -(void)registerSuperPropertiesOnce:(NSDictionary *)properties defaultValue:(id)defaultValue;
        [Export ("registerSuperPropertiesOnce:defaultValue:")]
        void RegisterSuperPropertiesOnce (NSDictionary properties, NSObject defaultValue);

        // -(void)unregisterSuperProperty:(NSString *)propertyName;
        [Export ("unregisterSuperProperty:")]
        void UnregisterSuperProperty (string propertyName);

        // -(void)clearSuperProperties;
        [Export ("clearSuperProperties")]
        void ClearSuperProperties ();

        // -(NSDictionary *)currentSuperProperties;
        [Export ("currentSuperProperties")]
        NSDictionary CurrentSuperProperties { get; }

        // -(void)timeEvent:(NSString *)event;
        [Export ("timeEvent:")]
        void TimeEvent (string @event);

        // -(void)clearTimedEvents;
        [Export ("clearTimedEvents")]
        void ClearTimedEvents ();

        // -(void)reset;
        [Export ("reset")]
        void Reset ();

        // -(void)flush;
        [Export ("flush")]
        void Flush ();

        // -(void)flushWithCompletion:(void (^)())handler;
        [Export ("flushWithCompletion:")]
        void FlushWithCompletion (Action handler);

        // -(void)archive;
        [Export ("archive")]
        void Archive ();

        // -(void)createAlias:(NSString *)alias forDistinctID:(NSString *)distinctID;
        [Export ("createAlias:forDistinctID:")]
        void CreateAlias (string alias, string distinctID);

        // -(NSString *)libVersion;
        [Export ("libVersion")]
        string LibVersion { get; }

        // -(void)showSurveyWithID:(NSUInteger)ID;
        [Export ("showSurveyWithID:")]
        void ShowSurveyWithID (nuint ID);

        // -(void)showSurvey;
        [Export ("showSurvey")]
        void ShowSurvey ();

        // -(void)showNotificationWithID:(NSUInteger)ID;
        [Export ("showNotificationWithID:")]
        void ShowNotificationWithID (nuint ID);

        // -(void)showNotificationWithType:(NSString *)type;
        [Export ("showNotificationWithType:")]
        void ShowNotificationWithType (string type);

        // -(void)showNotification;
        [Export ("showNotification")]
        void ShowNotification ();

        // -(void)joinExperiments;
        [Export ("joinExperiments")]
        void JoinExperiments ();

        // -(void)joinExperimentsWithCallback:(void (^)())experimentsLoadedCallback;
        [Export ("joinExperimentsWithCallback:")]
        void JoinExperimentsWithCallback (Action experimentsLoadedCallback);
    }

    // @interface MixpanelPeople : NSObject
    [BaseType (typeof(NSObject))]
    interface MixpanelPeople
    {
        // -(void)addPushDeviceToken:(NSData *)deviceToken;
        [Export ("addPushDeviceToken:")]
        void AddPushDeviceToken (NSData deviceToken);

        // -(void)set:(NSDictionary *)properties;
        [Export ("set:")]
        void Set (NSDictionary properties);

        // -(void)set:(NSString *)property to:(id)object;
        [Export ("set:to:")]
        void Set (string property, NSObject @object);

        // -(void)setOnce:(NSDictionary *)properties;
        [Export ("setOnce:")]
        void SetOnce (NSDictionary properties);

        // -(void)increment:(NSDictionary *)properties;
        [Export ("increment:")]
        void Increment (NSDictionary properties);

        // -(void)increment:(NSString *)property by:(NSNumber *)amount;
        [Export ("increment:by:")]
        void Increment (string property, NSNumber amount);

        // -(void)append:(NSDictionary *)properties;
        [Export ("append:")]
        void Append (NSDictionary properties);

        // -(void)union:(NSDictionary *)properties;
        [Export ("union:")]
        void Union (NSDictionary properties);

        // -(void)trackCharge:(NSNumber *)amount;
        [Export ("trackCharge:")]
        void TrackCharge (NSNumber amount);

        // -(void)trackCharge:(NSNumber *)amount withProperties:(NSDictionary *)properties;
        [Export ("trackCharge:withProperties:")]
        void TrackCharge (NSNumber amount, NSDictionary properties);

        // -(void)clearCharges;
        [Export ("clearCharges")]
        void ClearCharges ();

        // -(void)deleteUser;
        [Export ("deleteUser")]
        void DeleteUser ();
    }

    // @protocol MixpanelDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface MixpanelDelegate
    {
        // @optional -(BOOL)mixpanelWillFlush:(Mixpanel *)mixpanel;
        [Export ("mixpanelWillFlush:")]
        bool MixpanelWillFlush (Mixpanel mixpanel);
    }

  

    [BaseType(typeof(NSObject))]
    interface MPDesignerEventBindingRequestMesssage
    {
        [Field("MPDesignerEventBindingRequestMessageType", "__Internal")]
        NSString RequestMessageType { get; }
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MPEventBinding
    {
        // -(NSString *)libVersion;
        //[Export ("libVersion")]
       // string LibVersion { get; }

    }
        
    [BaseType(typeof(NSObject))]
    interface MPABTestDesignerConnection
    {
        // -(NSString *)libVersion;
        //[Export ("libVersion")]
        // string LibVersion { get; }

    }

    /*
    Undefined symbols for architecture i386:
        "_MPDesignerEventBindingRequestMessageType", referenced from:
        -[MPABTestDesignerConnection initWithURL:keepTrying:connectCallback:disconnectCallback:] in libMixpanel.a(MPABTestDesignerConnection.o)
        "_OBJC_CLASS_$_MPDesignerEventBindingRequestMessage", referenced from:
        objc-class-ref in libMixpanel.a(MPABTestDesignerConnection.o)
        "_OBJC_CLASS_$_MPDesignerTrackMessage", referenced from:
        objc-class-ref in libMixpanel.a(Mixpanel.o)
        "_OBJC_CLASS_$_MPEventBinding", referenced from:
        objc-class-ref in libMixpanel.a(Mixpanel.o)
        ld: symbol(s) not found for architecture i386
            clang: error: linker command failed with exit code 1 (use -v to see invocation)

            MTOUCH: error MT5214: Native linking failed, undefined sy
*/

    /*


    public delegate void MixpanelSurveyCompletion(NSArray surveys);

    [BaseType(typeof(NSObject))]
    public partial interface Mixpanel
    {

        [Export("people", ArgumentSemantic.Retain)]
        MixpanelPeople People { get; }

        [Export("distinctId", ArgumentSemantic.Copy)]
        string DistinctId { get; }

        [Export("nameTag", ArgumentSemantic.Copy)]
        string NameTag { get; set; }

        [Export("serverURL", ArgumentSemantic.Copy)]
        string ServerURL { get; set; }

        [Export("flushInterval")]
        uint FlushInterval { get; set; }

        [Export("flushOnBackground")]
        bool FlushOnBackground { get; set; }

        [Export("showNetworkActivityIndicator")]
        bool ShowNetworkActivityIndicator { get; set; }

        [Export("checkForSurveysOnActive")]
        bool CheckForSurveysOnActive { get; set; }

        [Export("showSurveyOnActive")]
        bool ShowSurveyOnActive { get; set; }

        [Export("checkForNotificationsOnActive")]
        bool CheckForNotificationsOnActive { get; set; }

        [Export("checkForVariantsOnActive")]
        bool CheckForVariantsOnActive { get; set; }

        [Export("showNotificationOnActive")]
        bool ShowNotificationOnActive { get; set; }

        [Export("miniNotificationPresentationTime")]
        float MiniNotificationPresentationTime { get; set; }

        [Export("delegate", ArgumentSemantic.Assign)]
        MixpanelDelegate Delegate { get; set; }

        [Static, Export("sharedInstanceWithToken:")]
        Mixpanel SharedInstanceWithToken(string apiToken);

        [Static, Export("sharedInstanceWithToken:launchOptions:")]
        Mixpanel SharedInstanceWithToken(string apiToken, NSDictionary launchOption);

        [Static, Export("sharedInstance")]
        Mixpanel SharedInstance { get; }

        [Export("initWithToken:launchOptions:andFlushInterval:")]
        IntPtr Constructor(string apiToken, NSDictionary launchOptions, uint flushInterval);

        [Export("initWithToken:andFlushInterval:")]
        IntPtr Constructor(string apiToken, uint flushInterval);

        [Export("identify:")]
        void Identify(string distinctId);

        [Export("track:")]
        void Track(string eventName);

        [Export("track:properties:")]
        void Track(string eventName, NSDictionary properties);

        [Export("trackPushNotification:")]
        void Track(NSDictionary userInfo);

        [Export("registerSuperProperties:")]
        void RegisterSuperProperties(NSDictionary properties);

        [Export("registerSuperPropertiesOnce:")]
        void RegisterSuperPropertiesOnce(NSDictionary properties);

        [Export("registerSuperPropertiesOnce:defaultValue:")]
        void RegisterSuperPropertiesOnce(NSDictionary properties, NSObject defaultValue);

        [Export("unregisterSuperProperty:")]
        void UnregisterSuperProperty(string propertyName);

        [Export("clearSuperProperties")]
        void ClearSuperProperties();

        [Export("currentSuperProperties")]
        NSDictionary CurrentSuperProperties { get; }

        [Export("reset")]
        void Reset();

        [Export("flush")]
        void Flush();

        [Export("archive")]
        void Archive();

        [Export("showSurveyWithID:")]
        void ShowSurveyWithID(uint ID);

        [Export("showSurvey")]
        void ShowSurvey();

        [Export("showNotificationWithID:")]
        void ShowNotificationWithID(uint ID);

        [Export("showNotificationWithType:")]
        void ShowNotificationWithType(string type);

        [Export("showNotification")]
        void ShowNotification();

        [Export("joinExperiments")]
        void JoinExperiments();

        [Export("createAlias:forDistinctID:")]
        void CreateAlias(string alias, string distinctID);

        // LL: Added this for Tink
        [Export("lla_checkForSurveysWithCompletion:")]
        void LLACheckForSurveys(MixpanelSurveyCompletion completion);

        [Export("lla_showSurveyWithObject:")]
        void LLAShowSurvey(NSObject survey);

        [Export("lla_markSurvey:shown:withAnswerCount:")]
        void LLAMarkSurvey(NSObject survey, bool shown, int count);
    }

    [BaseType(typeof(NSObject))]
    public partial interface MixpanelPeople
    {

        [Export("addPushDeviceToken:")]
        void AddPushDeviceToken(NSData deviceToken);

        [Export("set:")]
        void Set(NSDictionary properties);

        [Export("set:to:")]
        void Set(string property, NSObject obj);

        [Export("setOnce:")]
        void SetOnce(NSDictionary properties);

        [Export("increment:")]
        void Increment(NSDictionary properties);

        [Export("increment:by:")]
        void Increment(string property, NSNumber amount);

        [Export("append:")]
        void Append(NSDictionary properties);

        [Export("union:")]
        void Union(NSDictionary properties);

        [Export("trackCharge:")]
        void TrackCharge(NSNumber amount);

        [Export("trackCharge:withProperties:")]
        void TrackCharge(NSNumber amount, NSDictionary properties);

        [Export("clearCharges")]
        void ClearCharges();

        [Export("deleteUser")]
        void DeleteUser();
    }

    [Model, BaseType(typeof(NSObject))]
    public partial interface MixpanelDelegate
    {

        [Export("mixpanelWillFlush:")]
        bool MixpanelWillFlush(Mixpanel mixpanel);
    }
    */
}
