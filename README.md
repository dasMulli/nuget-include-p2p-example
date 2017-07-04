# Example of a NuGet package including its ProjectReference projects

The example `LibA/LibA.csproj` creates a NuGet package that incudes both `LibB` and `PrivateLib` in a single package.

Furthermore, only `LibB` is visible to consuming projects. This is done by explicitly copying assemlbies to the `ref/` folder. If you don't want this behavior, omit all `ref/` entries in the `nuspec` so all assemblies in `lib/` will be used. In MSBuild 15.3 / Roslyn 2.3.0 the `ref` assmeblies could even be generated using the reference assembly generation capabilities of the compiler, resuling in smaller binaries in the `ref` folder.