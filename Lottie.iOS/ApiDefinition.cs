using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using Lottie;

namespace Lottie.iOS
{
    [Static]
    partial interface Constants
    {
        // extern double LottieVersionNumber;
        [Field("LottieVersionNumber", "__Internal")]
        double LottieVersionNumber { get; }

        // extern const unsigned char [] LottieVersionString;
        [Field("LottieVersionString", "__Internal")]
        IntPtr LottieVersionString { get; }
    }

    // @interface AnimatedControl : UIControl
    [BaseType(typeof(UIControl), Name = "_TtC6Lottie15AnimatedControl")]
    interface AnimatedControl
    {
        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

        // @property (getter = isEnabled, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // @property (getter = isSelected, nonatomic) BOOL selected;
        [Export("selected")]
        bool Selected { [Bind("isSelected")] get; set; }

        // @property (getter = isHighlighted, nonatomic) BOOL highlighted;
        [Export("highlighted")]
        bool Highlighted { [Bind("isHighlighted")] get; set; }

        // -(BOOL)beginTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
        [Export("beginTrackingWithTouch:withEvent:")]
        bool BeginTrackingWithTouch(UITouch touch, [NullAllowed] UIEvent @event);

        // -(BOOL)continueTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
        [Export("continueTrackingWithTouch:withEvent:")]
        bool ContinueTrackingWithTouch(UITouch touch, [NullAllowed] UIEvent @event);

        // -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)event;
        [Export("endTrackingWithTouch:withEvent:")]
        void EndTrackingWithTouch([NullAllowed] UITouch touch, [NullAllowed] UIEvent @event);

        // -(void)cancelTrackingWithEvent:(UIEvent * _Nullable)event;
        [Export("cancelTrackingWithEvent:")]
        void CancelTrackingWithEvent([NullAllowed] UIEvent @event);

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }
    }

    // @interface AnimatedButton : AnimatedControl
    [BaseType(typeof(AnimatedControl), Name = "_TtC6Lottie14AnimatedButton")]
    interface AnimatedButton
    {
        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

        // -(BOOL)beginTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
        [Export("beginTrackingWithTouch:withEvent:")]
        bool BeginTrackingWithTouch(UITouch touch, [NullAllowed] UIEvent @event);

        // -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)event;
        [Export("endTrackingWithTouch:withEvent:")]
        void EndTrackingWithTouch([NullAllowed] UITouch touch, [NullAllowed] UIEvent @event);
    }

    // @interface AnimatedSwitch : AnimatedControl
    [BaseType(typeof(AnimatedControl), Name = "_TtC6Lottie14AnimatedSwitch")]
    interface AnimatedSwitch
    {
        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

        // -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)event;
        [Export("endTrackingWithTouch:withEvent:")]
        void EndTrackingWithTouch([NullAllowed] UITouch touch, [NullAllowed] UIEvent @event);
    }

    // @interface AnimationSubview : UIView
    [BaseType(typeof(UIView), Name = "_TtC6Lottie16AnimationSubview")]
    interface AnimationSubview
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface LottieView : UIView
    [BaseType(typeof(UIView), Name = "_TtC6Lottie10LottieView")]
    interface LottieView
    {
        // -(void)didMoveToWindow;
        [Export("didMoveToWindow")]
        void DidMoveToWindow();

        // @property (nonatomic) UIViewContentMode contentMode;
        [Export("contentMode", ArgumentSemantic.Assign)]
        UIViewContentMode ContentMode { get; set; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface AnimationView : LottieView
    [BaseType(typeof(LottieView), Name = "_TtC6Lottie13AnimationView")]
    interface AnimationView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }
    }

    // @interface CompatibleAnimation : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Lottie19CompatibleAnimation")]
    [DisableDefaultCtor]
    interface CompatibleAnimation
    {
        // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name bundle:(NSBundle * _Nonnull)bundle __attribute__((objc_designated_initializer));
        [Export("initWithName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor(string name, NSBundle bundle);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        CompatibleAnimation New();
    }

    // @interface CompatibleAnimationKeypath : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Lottie26CompatibleAnimationKeypath")]
    [DisableDefaultCtor]
    interface CompatibleAnimationKeypath
    {
        // -(instancetype _Nonnull)initWithKeypath:(NSString * _Nonnull)keypath __attribute__((objc_designated_initializer));
        [Export("initWithKeypath:")]
        [DesignatedInitializer]
        IntPtr Constructor(string keypath);

        // -(instancetype _Nonnull)initWithKeys:(NSArray<NSString *> * _Nonnull)keys __attribute__((objc_designated_initializer));
        [Export("initWithKeys:")]
        [DesignatedInitializer]
        IntPtr Constructor(string[] keys);

        // +(instancetype _Nonnull)new __attribute__((deprecated("-init is unavailable")));
        [Static]
        [Export("new")]
        CompatibleAnimationKeypath New();
    }

    // @interface CompatibleAnimationView : UIView
    [BaseType(typeof(UIView), Name = "_TtC6Lottie23CompatibleAnimationView")]
    interface CompatibleAnimationView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // @property (nonatomic, strong) CompatibleAnimation * _Nullable compatibleAnimation;
        [NullAllowed, Export("compatibleAnimation", ArgumentSemantic.Strong)]
        CompatibleAnimation CompatibleAnimation { get; set; }

        // @property (nonatomic) CGFloat loopAnimationCount;
        [Export("loopAnimationCount")]
        nfloat LoopAnimationCount { get; set; }

        // @property (nonatomic) UIViewContentMode contentMode;
        [Export("contentMode", ArgumentSemantic.Assign)]
        UIViewContentMode ContentMode { get; set; }

        // @property (nonatomic) BOOL shouldRasterizeWhenIdle;
        [Export("shouldRasterizeWhenIdle")]
        bool ShouldRasterizeWhenIdle { get; set; }

        // @property (nonatomic) CGFloat currentProgress;
        [Export("currentProgress")]
        nfloat CurrentProgress { get; set; }

        // @property (nonatomic) NSTimeInterval currentTime;
        [Export("currentTime")]
        double CurrentTime { get; set; }

        // @property (nonatomic) CGFloat currentFrame;
        [Export("currentFrame")]
        nfloat CurrentFrame { get; set; }

        // @property (readonly, nonatomic) CGFloat realtimeAnimationFrame;
        [Export("realtimeAnimationFrame")]
        nfloat RealtimeAnimationFrame { get; }

        // @property (readonly, nonatomic) CGFloat realtimeAnimationProgress;
        [Export("realtimeAnimationProgress")]
        nfloat RealtimeAnimationProgress { get; }

        // @property (nonatomic) CGFloat animationSpeed;
        [Export("animationSpeed")]
        nfloat AnimationSpeed { get; set; }

        // @property (nonatomic) BOOL respectAnimationFrameRate;
        [Export("respectAnimationFrameRate")]
        bool RespectAnimationFrameRate { get; set; }

        // -(void)play;
        [Export("play")]
        void Play();

        // -(void)playWithCompletion:(void (^ _Nullable)(BOOL))completion;
        [Export("playWithCompletion:")]
        void PlayWithCompletion([NullAllowed] Action<bool> completion);

        // -(void)playFromProgress:(CGFloat)fromProgress toProgress:(CGFloat)toProgress completion:(void (^ _Nullable)(BOOL))completion;
        [Export("playFromProgress:toProgress:completion:")]
        void PlayFromProgress(nfloat fromProgress, nfloat toProgress, [NullAllowed] Action<bool> completion);

        // -(void)playFromFrame:(CGFloat)fromFrame toFrame:(CGFloat)toFrame completion:(void (^ _Nullable)(BOOL))completion;
        [Export("playFromFrame:toFrame:completion:")]
        void PlayFromFrame(nfloat fromFrame, nfloat toFrame, [NullAllowed] Action<bool> completion);

        // -(void)playFromMarker:(NSString * _Nonnull)fromMarker toMarker:(NSString * _Nonnull)toMarker completion:(void (^ _Nullable)(BOOL))completion;
        [Export("playFromMarker:toMarker:completion:")]
        void PlayFromMarker(string fromMarker, string toMarker, [NullAllowed] Action<bool> completion);

        // -(void)stop;
        [Export("stop")]
        void Stop();

        // -(void)pause;
        [Export("pause")]
        void Pause();

        // -(void)reloadImages;
        [Export("reloadImages")]
        void ReloadImages();

        // -(void)forceDisplayUpdate;
        [Export("forceDisplayUpdate")]
        void ForceDisplayUpdate();

        // -(id _Nullable)getValueFor:(CompatibleAnimationKeypath * _Nonnull)keypath atFrame:(CGFloat)atFrame __attribute__((warn_unused_result));
        [Export("getValueFor:atFrame:")]
        [return: NullAllowed]
        NSObject GetValueFor(CompatibleAnimationKeypath keypath, nfloat atFrame);

        // -(void)logHierarchyKeypaths;
        [Export("logHierarchyKeypaths")]
        void LogHierarchyKeypaths();

        // -(void)addSubview:(AnimationSubview * _Nonnull)subview forLayerAt:(CompatibleAnimationKeypath * _Nonnull)keypath;
        [Export("addSubview:forLayerAt:")]
        void AddSubview(AnimationSubview subview, CompatibleAnimationKeypath keypath);

        // -(CGRect)convertWithRect:(CGRect)rect toLayerAt:(CompatibleAnimationKeypath * _Nullable)keypath __attribute__((warn_unused_result));
        [Export("convertWithRect:toLayerAt:")]
        CGRect ConvertWithRect(CGRect rect, [NullAllowed] CompatibleAnimationKeypath keypath);

        // -(CGPoint)convertWithPoint:(CGPoint)point toLayerAt:(CompatibleAnimationKeypath * _Nullable)keypath __attribute__((warn_unused_result));
        [Export("convertWithPoint:toLayerAt:")]
        CGPoint ConvertWithPoint(CGPoint point, [NullAllowed] CompatibleAnimationKeypath keypath);

        // -(CGFloat)progressTimeForMarker:(NSString * _Nonnull)named __attribute__((warn_unused_result));
        [Export("progressTimeForMarker:")]
        nfloat ProgressTimeForMarker(string named);

        // -(CGFloat)frameTimeForMarker:(NSString * _Nonnull)named __attribute__((warn_unused_result));
        [Export("frameTimeForMarker:")]
        nfloat FrameTimeForMarker(string named);
    }

}
