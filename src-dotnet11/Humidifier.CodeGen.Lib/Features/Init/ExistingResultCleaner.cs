namespace Humidifier.CodeGen.Lib.Features.Init;

public class ExistingResultCleaner
{
    public void CleanupOldGeneratedResults(string humidifierPath)
    {
        humidifierPath = Path.GetFullPath(humidifierPath);
        var projectPath = Path.Combine(Path.GetDirectoryName(humidifierPath)!, "Humidifier.csproj");
        if (Path.GetFileName(humidifierPath) != "Gen" || !File.Exists(projectPath))
        {
            throw new InvalidOperationException($"Refusing to clean a directory outside Humidifier/Gen: {humidifierPath}");
        }

        Console.WriteLine("Cleaning files");

        foreach (var directory in Directory.GetDirectories(humidifierPath))
        {
            if (directory.EndsWith("bin") || directory.EndsWith("obj"))
            {
                continue;
            }

            if (directory.Contains("Serverless"))
            {
                continue;
            }

            if (directory.Contains("1-Custom"))
            {
                continue;
            }

            if (directory.Contains("Interfaces"))
            {
                continue;
            }

            Directory.Delete(directory, true);
        }
    }
}
