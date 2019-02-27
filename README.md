# mySMS Single Sign-On Demo - ASP.NET Core edition
A sample project showing you how to implement a single sign-on using ASP.NET core targeting the .NET Framework and Visual Studio 2015 or above.

# Prerequisites
All prerequisites are included in the Visual Studio project. However, if you want to start from scratch, you need to install libsodium-netcore using NuGet: https://www.nuget.org/packages/libsodium-netcore/.
The package is based on libsodium-net, so for further information such as documentation, please refer to: https://github.com/adamcaudill/libsodium-net and https://bitbeans.gitbooks.io/libsodium-net/content/.

# Addition information
The IIS Express settings have been changed and it now listens to localhost:4200 and 127.0.0.1:4200 additionally. In order to have the changed configuration working correctly, it might be necessary to start Visual Studio with administrative rights.
