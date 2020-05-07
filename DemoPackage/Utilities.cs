using System.Reflection;

namespace DemoPackage
{
    public static class Utilities
    {
        public static string GetAssemblyVersion()
        {
            return Assembly.GetEntryAssembly()?.GetName().Version?.ToString();
        }
    }
}