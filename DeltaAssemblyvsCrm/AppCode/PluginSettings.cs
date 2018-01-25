
namespace Carfup.XTBPlugins.AppCode
{
    public class PluginSettings
    {
        public bool? AllowLogUsage { get; set; } = true;
        public string CurrentVersion { get; set; } = DeltaAssemblyvsCrm.DeltaAssemblyvsCrm.CurrentVersion;
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
        public static string INSIGHTS_INTRUMENTATIONKEY = "80afe47d-768b-4485-a2b1-ab1693bb97b4"; // "INSIGHTS_INTRUMENTATIONKEY_TOREPLACE";
    }

    // EventType to qualify which action was performed by the plugin
    static class LogAction
    {
        public const string PluginClosed = "PluginClosed";
        public const string StatsAccepted = "StatsAccepted";
        public const string StatsDenied = "StatsDenied";
        public const string SettingsSaved = "SettingsSaved";
        public const string SettingLoaded = "SettingLoaded";
        public const string SolutionsCompared = "SolutionsCompared";
        public const string CRMAssembliesLoaded = "CRMAssembliesLoaded";
        public const string AssemblyLoaded = "AssemblyLoaded";
        public const string PluginsLoaded = "PluginsLoaded";
        public const string PluginsCompared = "PluginsCompared";
    }
}
