# Geosoft GX for .Net Repository

This is the repository for Geosoft GX Developer support for .Net development. Refer to the documentation for more information.

[GX Developer documentation](https://geosoftgxdev.atlassian.net/wiki/display/GD/Python+in+GX+Developer)

[.Net Development](https://geosoftgxdev.atlassian.net/wiki/spaces/GXD93/pages/78053479/.NET+Development)

Also see the [Geosoft Inc. organization on Github](https://github.com/GeosoftInc) for the other programming language specific repos.

Quick Start
-----------

The `build.proj` and `env.targets` files contain [MSBuild](https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild) scripts that  can be used to build the examples or launch Visual Studio with the correct environments defined.

[Visual Studio Community 2017](https://www.visualstudio.com/downloads/) is recommened for developers that do not yet have access to Visual Studio. It should also be possible to build using other toolsets (e.g. MingW), but this is neither tested nor supported.

The MSBuild scripts require [the MSBuild Extension Pack](http://www.msbuildextensionpack.com/).

The commands are intended to be executed under the [Developer Command Prompt for Visual Studio](https://docs.microsoft.com/en-us/dotnet/framework/tools/developer-command-prompt-for-vs)

### Commandline Build
```
msbuild
```

### Launch Visual Studio
```
msbuild /t:StartDevEnv
```
Then open `examples\examples.sln`.

### References

All Geosoft assemblies are references from the Geosoft Desktop Applications bin directory.

### x86 References
The `x86_references` directory provide minimal assemblies necessary to build assemblies targetting x86. These assemblies cannot be used and is only neccessary to be able to use the Visual Studio Windows Forms Designer since Visual Studio is at this moment still an x86 application.


License
-------
Any source code found here are released under the [BSD 2-clause license](https://github.com/GeosoftInc/gxpy/blob/master/LICENSE). Core functionality exposed by the GX API may have additional license implications. For more information consult the [License page in the GX Developer Wiki](https://geosoftgxdev.atlassian.net/wiki/spaces/GD/pages/2359406/License)
