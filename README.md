# Lottie.Xamarin.iOS
Lottie binding lib for Xamarin iOS
[Version] lottie-ios (3.1.2)

How to Binding swift iOS Lib?

1. sharpie pod init iphoneos12.4 lottie-ios
2. pod install
3. sharpie pod bind
4. sudo xcode-select --switch /Applications/Xcode.app
5. cd Pods
6. xcodebuild -project Pods.xcodeproj -target lottie-ios -sdk iphonesimulator12.4 -configuration Release build
7. lipo -create /Users/letrungdo/Binding/Lottie.framework/Lottie /Users/letrungdo/build/Release-iphonesimulator/lottie-ios/Lottie.framework/Lottie -output /Users/letrungdo/Lottie_OK

Ref:
1. https://qiita.com/iseebi/items/70e70c2d881c5ce27f4e
2. https://medium.com/@Flash3001/binding-swift-libraries-xamarin-ios-ff32adbc7c76
3. https://cocoapods.org/pods/lottie-ios
4. https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/examples/cocoapod
