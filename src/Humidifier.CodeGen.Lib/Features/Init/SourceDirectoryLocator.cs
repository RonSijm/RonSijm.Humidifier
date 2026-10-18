namespace Humidifier.CodeGen.Lib.Features.Init;

public class SourceDirectoryLocator(PathLocator pathLocator)
{
    public string TryFindSourcePath(string solutionDirectory = null)
    {
        solutionDirectory = Path.GetFullPath(solutionDirectory ?? Directory.GetCurrentDirectory());
        var trackDirectory = Path.Combine(solutionDirectory, "src");
        if (File.Exists(Path.Combine(trackDirectory, "Humidifier.sln")))
            solutionDirectory = trackDirectory;

        var sourcePath = pathLocator.FindPath(solutionDirectory, "Humidifier.sln");

        if (sourcePath == null)
        {
            Console.WriteLine("Could not find the solution file.");

            // Throwing exception to stop Github from continuing the workflow
            throw new FileNotFoundException("Humidifier.sln");
        }

        if (Path.GetFileName(Path.TrimEndingDirectorySeparator(sourcePath)) == "src-dotnet11")
            throw new InvalidOperationException("The stable generator must target src, not the .NET 11 src-dotnet11 tree.");

        return sourcePath;
    }
}
