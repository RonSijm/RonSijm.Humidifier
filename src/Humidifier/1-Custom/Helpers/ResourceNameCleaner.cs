namespace Humidifier.Helpers
{
    internal static class ResourceNameCleaner
    {
        public static string CleanName(this string name)
        {
            if (name == null)
            {
                return null;
            }

            var cleanName = name.Replace("-", string.Empty).Replace(" ", string.Empty)
                .Replace("/", string.Empty) // For log groups and paths
                .Replace(".", string.Empty); // Not allowed to add dots in resource names

            return cleanName;
        }
    }
}
