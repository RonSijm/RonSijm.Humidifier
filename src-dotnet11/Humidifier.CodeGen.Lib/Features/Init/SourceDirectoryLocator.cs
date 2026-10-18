namespace Humidifier.CodeGen.Lib.Features.Init;

public class SourceDirectoryLocator(PathLocator pathLocator)
{
    public string TryFindSourcePath(string solutionDirectory = null)
    {
        solutionDirectory = Path.GetFullPath(solutionDirectory ?? Directory.GetCurrentDirectory());
        var trackDirectory = Path.Combine(solutionDirectory, "src-dotnet11");
        if (File.Exists(Path.Combine(trackDirectory, "Humidifier.sln")))
            solutionDirectory = trackDirectory;

        var sourcePath = pathLocator.FindPath(solutionDirectory, "Humidifier.sln");

        if (sourcePath == null)
        {
            Console.WriteLine("Could not find the solution file.");

            // Throwing exception to stop Github from continuing the workflow
            throw new FileNotFoundException("Humidifier.sln");
        }

        if (Path.GetFileName(Path.TrimEndingDirectorySeparator(sourcePath)) == "src")
            throw new InvalidOperationException("The .NET 11 generator must target src-dotnet11, not the stable src tree.");

        return sourcePath;
    }
}
