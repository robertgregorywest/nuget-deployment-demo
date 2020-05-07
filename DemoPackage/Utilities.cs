using System.Reflection;

namespace DemoPackage
{
    public static class Utilities
    {
        public static string GetAssemblyVersion()
        {
            return Assembly.GetAssembly(typeof(Utilities))?.GetName().Version?.ToString();
        }
    }
}