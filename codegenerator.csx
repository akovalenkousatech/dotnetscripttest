#! "netcoreapp3.0"
#r "nuget: Microsoft.CodeAnalysis.Workspaces.MSBuild, 3.4.0"

using (var workspace = Microsoft.CodeAnalysis.MSBuild.MSBuildWorkspace.Create())
{
    var project = await workspace.OpenProjectAsync("roslyngenerator.csproj");
    foreach (var document in project.Documents)
    {
        Console.WriteLine(document.Name);
    }
}