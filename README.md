# What is this project about?

Deezer Xamarin Android is a set of metadata bindings and helper classes that can be used in Xamarin Android or in the Android project of Xamarin Forms.

# How to get started?

You should clone this repository, or download it, and build the project yourself, generating a usable dll. If you are unable to do so you can download the dll file here https://github.com/CodeMyst/DeezerXamarinAndroid/releases and add it to your Xamarin Android project.

# How to use it?

https://developers.deezer.com/sdk/android shows you how to get started with Deezer SDK. It is written in Java, though, so you may not know how to implement it in C#. Most of the stuff is very similar and can easily be understood but stuff like getting user or song data is a lot more different in C#. It is on my roadmap to add some helper classes and write better documentation on how to use the SDK in C# to make it easier for everyone to use it. **However, if you are struggling with implementing it in C# and the documentation or the helper classes haven't been implemented yet, feel free to contact me, I'll be glad to help anyone.**

Further documentation on the SDK you can find by downloading the Deezer SDK (Java) from this website: https://developers.deezer.com/sdk/android. Inside the archive is the documentation on most of the stuff.

# Project properties
Android Class Parser - class-parse<br>
Android Codegen Target - XAJavaInterop1

If the current Deezer Android SDK .aar file in the DeezerXamarinAndroid/Jars folder is not the latest one then download the most recent version from here: https://developers.deezer.com/sdk/android, extact the zip and put the .aar file in the Jars folder, replacing the old one.

You have to change the build action of the .aar file to LibraryProjectZip, else it won't build.
