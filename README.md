# mySMS Single Sign-On Demo for ASP.NET Core
A sample of implementing a single sign-on for the mySMS platform using ASP.NET Core targeting the .NET Framework and Visual Studio 2015 and above. Open the .sln file with Visual Studio and run the project. Once started, the server listens to port 4200, waiting for a valid request. A valid rerquest contains a token that will be used to authenticate against the mySMS platform. The browser output will be "true" if the token is correct and the authentication was successful or "false" if the token was invalid, empty or the data could not be proceeded correctly.

# Prerequisites
All prerequisites and dependencies are included in the Visual Studio project. However, if you want to start from scratch, download libsodium-netcore from [here](https://www.nuget.org/packages/libsodium-netcore/) or use NuGet and search for libsodium-netcore. That package is based on https://github.com/adamcaudill/libsodium-net, please refer to http://bitbeans.gitbooks.io/libsodium-net/content/ for documentation.

# Additional information
The IIS Express configuration has been changed in order to make IIS Express listen to 127.0.0.1:4200 in addition to localhost:4200. It might be necessary to start Visual Studio with administrative privileges in order to have the application running correctly.
