# DeezerXamarinAndroid
Deezer Android SDK bindings for Xamarin.Android (or Xamarin.Forms but only in the Android project).

## Project properties
Android Class Parser - class-parse<br>
Android Codegen Target - XAJavaInterop1

If the current Deezer Android SDK .aar file in the DeezerXamarinAndroid/Jars folder is not the latest one then download the most recent version from here: https://developers.deezer.com/sdk/android, extact the zip and put the .aar file in the Jars folder, replacing the old one.

You have to change the build action of the .aar file to LibraryProjectZip, else it won't build.