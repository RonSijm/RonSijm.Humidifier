namespace Humidifier.CodeGen.Features.Init;

public class SourceDirectoryLocator(PathLocator pathLocator)
{
    public string TryFindSourcePath(string[] args)
    {
            var solutionDirectory = GetSolutionDirectory(args);
            var sourcePath = pathLocator.FindPath(solutionDirectory, "Humidifier.sln");

            if (sourcePath == null)
            {
                Console.WriteLine("Could not find the solution file.");

                // Throwing exception to stop Github from continuing the workflow
                throw new FileNotFoundException("Humidifier.sln");
            }

            return sourcePath;
        }

    public string GetSolutionDirectory(string[] args)
    {
            string currentDirectory = null;

            for (var i = 0; i < args.Length; i++)
            {
                if (args[i].Equals("-directory", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                {
                    currentDirectory = args[i + 1];
                }
            }

            if (currentDirectory == null)
            {
                Console.WriteLine("-directory args not specified. Using current dir.");
                currentDirectory = Directory.GetCurrentDirectory();
            }
            else
            {
                Console.WriteLine($"-directory specified. Using {currentDirectory}");
            }

            if (currentDirectory.EndsWith("RonSijm.Humidifier"))
            {
                currentDirectory = Path.Combine(currentDirectory, "src");
            }

            return currentDirectory;
        }
}