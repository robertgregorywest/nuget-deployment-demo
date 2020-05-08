using System.Diagnostics;
using System.Reflection;

namespace DemoPackage
{
    public static class Utilities
    {
        public static string GetAssemblyVersion()
        {
            return Assembly.GetAssembly(typeof(Utilities))?.GetName().Version?.ToString();
        }
        
        public static string GetFileVersion()
        {
            var assembly = Assembly.GetAssembly(typeof(Utilities));
            var fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fileVersionInfo.FileVersion;
        }
        
        public static string GetInformationalVersion()
        {
            var assembly = Assembly.GetAssembly(typeof(Utilities));
            return assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        }
    }
}