namespace Humidifier.CodeGen.Features.Init;

public class ExistingResultCleaner
{
    public void CleanupOldGeneratedResults(string humidifierPath)
    {
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

            Directory.Delete(directory, true);
        }
    }
}