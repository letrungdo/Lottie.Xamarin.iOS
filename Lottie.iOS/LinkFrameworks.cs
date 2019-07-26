using ObjCRuntime;

[assembly: LinkWith("Lottie.framework",
   LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64,
   SmartLink = true,
   ForceLoad = true,
   LinkerFlags = "-lxml2 -ObjC",
   Frameworks = "CoreFoundation CoreGraphics CoreImage Foundation Metal QuartzCore UIKit")]
