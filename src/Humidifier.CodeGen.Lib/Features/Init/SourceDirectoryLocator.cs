namespace Humidifier.CodeGen.Lib.Features.Init;

public class SourceDirectoryLocator(PathLocator pathLocator)
{
    public string TryFindSourcePath(string solutionDirectory = null)
    {
        var sourcePath = pathLocator.FindPath(solutionDirectory, "Humidifier.sln");

        if (sourcePath == null)
        {
            Console.WriteLine("Could not find the solution file.");

            // Throwing exception to stop Github from continuing the workflow
            throw new FileNotFoundException("Humidifier.sln");
        }

        return sourcePath;
    }
}