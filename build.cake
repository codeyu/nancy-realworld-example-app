var target = Argument("target", "Default");
var tag = Argument("tag", "cake");

Task("Restore")
  .Does(() =>
{
    DotNetCoreRestore(".");
});

Task("Build")
  .Does(() =>
{
    var settings = new DotNetCoreBuildSettings
    {
        Framework = "netcoreapp1.1",
        Configuration = "Release",
        Runtime = "ubuntu.16.10-x64",
        VersionSuffix = tag
    };
    DotNetCoreBuild(".", settings);
});

Task("Test")
  .Does(() =>
{
    var files = GetFiles("test/**/*.csproj");
    foreach(var file in files)
    {
        DotNetCoreTest(file.ToString());
    }
});

Task("Publish")
  .Does(() =>
{
    var settings = new DotNetCorePublishSettings
    {
        Framework = "netcoreapp1.1",
        Configuration = "Release",
        Runtime = "ubuntu.16.10-x64",
        OutputDirectory = "./publish",
        VersionSuffix = tag
    };
                
    DotNetCorePublish("src/NancyRealWorld", settings);
});

Task("Default")
    .IsDependentOn("Restore")
    .IsDependentOn("Build")
    .IsDependentOn("Test")
    .IsDependentOn("Publish");

 Task("Rebuild")
    .IsDependentOn("Restore")
    .IsDependentOn("Build");


RunTarget(target);