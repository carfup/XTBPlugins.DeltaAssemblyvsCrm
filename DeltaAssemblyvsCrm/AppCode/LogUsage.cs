﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

namespace Carfup.XTBPlugins.AppCode
{
    public class LogUsage
    {

        private TelemetryClient telemetry = null;
        private bool forceLog { get; set; } = false;

        private DeltaAssemblyvsCrm.DeltaAssemblyvsCrm deltaVsCRM = null;
        public LogUsage(DeltaAssemblyvsCrm.DeltaAssemblyvsCrm deltaVsCRM)
        {
            this.deltaVsCRM = deltaVsCRM;

            TelemetryConfiguration.Active.InstrumentationKey = CustomParameter.INSIGHTS_INTRUMENTATIONKEY;
            this.telemetry = new TelemetryClient();
            this.telemetry.Context.Component.Version = this.deltaVsCRM.CurrentVersion;
            this.telemetry.Context.Device.Id = this.deltaVsCRM.GetType().Name;
        }

        public void updateForceLog()
        {
            this.forceLog = true;
        }

        public void LogData(string type, string action, Exception exception = null)
        {
            if (this.deltaVsCRM.settings.AllowLogUsage == true || this.forceLog)
            {
                switch (type)
                {
                    case EventType.Event:
                        this.telemetry.TrackEvent(action, completeLog(action));
                        break;
                    case EventType.Dependency:
                        //this.telemetry.TrackDependency(todo);
                        break;
                    case EventType.Exception:
                        this.telemetry.TrackException(exception, completeLog(action));
                        break;
                    case EventType.Trace:
                        this.telemetry.TrackTrace(action, completeLog(action));
                        break;
                }
            }

            if (this.forceLog)
                this.forceLog = false;
        }

        public void Flush()
        {
            this.telemetry.Flush();
        }


        public Dictionary<string, string> completeLog(string action = null)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "plugin", telemetry.Context.Device.Id }
            };

            if (action != null)
                dictionary.Add("action", action);

            return dictionary;
        }
    }
}
