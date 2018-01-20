using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carfup.XTBPlugins.AppCode
{
    public class PluginSettings
    {
        public bool? AllowLogUsage { get; set; }
        public string CurrentVersion { get; set; }
    }

    // EventType to qualify which type of telemetry we send
    static class EventType
    {
        public const string Event = "event";
        public const string Trace = "trace";
        public const string Dependency = "dependency";
        public const string Exception = "exception";
    }

    public static class CustomParameter
    {
        public static string INSIGHTS_INTRUMENTATIONKEY = "INSIGHTS_INTRUMENTATIONKEY_TOREPLACE";
    }

    // EventType to qualify which action was performed by the plugin
    static class LogAction
    {
        public const string ClosingPlugin = "Closing Plugin";
        public const string AcceptingStats = "Accepting Stats";
        public const string DenyingStats = "Denying Stats";
        public const string SavingSettings = "Saving Settings";
        public const string LoadingSettings = "Loading Settings";
        public const string ComparingSolutions = "Comparing Solutions";
        public const string LoadingCRMAssemblies = "Loading CRM Assemblies";
        public const string LoadingAssembly = "Loading Assembly";
        public const string LoadingPlugins = "Loading Plugins";
        public const string ComparingPlugins = "Comparing Plugins";
    }
}
