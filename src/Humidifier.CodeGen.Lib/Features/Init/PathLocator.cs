namespace Humidifier.CodeGen.Lib.Features.Init;

public class PathLocator
{
    public string FindPath(string path, string searchPattern)
    {
            Console.WriteLine($"Searching in: {path}");

            var files = Directory.GetFiles(path, searchPattern, SearchOption.TopDirectoryOnly);
            if (files.Any())
            {
                Console.WriteLine($"Found {searchPattern} in: {path}");
                return path;
            }

            var parent = Directory.GetParent(path);
            if (parent != null && parent.Exists)
            {
                Console.WriteLine($"Moving up to parent directory: {parent.FullName}");
                return FindPath(parent.FullName, searchPattern);
            }

            Console.WriteLine("Reached the root directory without finding the file.");
            return null;
        }
}