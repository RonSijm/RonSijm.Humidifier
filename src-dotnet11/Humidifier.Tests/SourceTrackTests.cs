using Humidifier.CodeGen.Lib.Features.Init;

namespace Humidifier.Tests;

public class SourceTrackTests
{
    [Fact]
    public void RepositoryRootSelectsUnionSourceWhenBothTracksExist()
    {
        WithSourceTracks(root =>
        {
            var locator = new SourceDirectoryLocator(new PathLocator());
            Assert.Equal(Path.Combine(root, "src-dotnet11"), locator.TryFindSourcePath(root));
            var relativeRoot = Path.GetRelativePath(Directory.GetCurrentDirectory(), root);
            Assert.Equal(Path.Combine(root, "src-dotnet11"), locator.TryFindSourcePath(relativeRoot));
        });
    }

    [Fact]
    public void UnionGeneratorRefusesToOverwriteStableSource()
    {
        WithSourceTracks(root =>
        {
            var locator = new SourceDirectoryLocator(new PathLocator());
            Assert.Throws<InvalidOperationException>(() => locator.TryFindSourcePath(Path.Combine(root, "src")));
        });
    }

    private static void WithSourceTracks(Action<string> check)
    {
        var root = Path.Combine(Path.GetTempPath(), "HumidifierSourceTracks-" + Guid.NewGuid());
        try
        {
            foreach (var source in new[] { "src", "src-dotnet11" })
            {
                var path = Path.Combine(root, source);
                Directory.CreateDirectory(path);
                File.WriteAllText(Path.Combine(path, "Humidifier.sln"), string.Empty);
            }
            check(root);
        }
        finally
        {
            Directory.Delete(root, true);
        }
    }
}
