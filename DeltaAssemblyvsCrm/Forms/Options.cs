using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carfup.XTBPlugins.AppCode;

namespace Carfup.XTBPlugins.Forms
{
    public partial class Options : Form
    {
        private DeltaAssemblyvsCrm.DeltaAssemblyvsCrm deltaVsCRM;
        public Options(DeltaAssemblyvsCrm.DeltaAssemblyvsCrm deltaVsCRM)
        {
            InitializeComponent();
            this.deltaVsCRM = deltaVsCRM;
            PopulateSettings(this.deltaVsCRM.settings);
        }

        private void PopulateSettings(PluginSettings settings)
        {
            if (settings == null)
            {
                settings = new PluginSettings();
            }

            checkboxAllowStats.Checked = settings.AllowLogUsage != false;
        }

        internal PluginSettings GetSettings()
        {
            var settings = this.deltaVsCRM.settings;
            settings.AllowLogUsage = checkboxAllowStats.Checked;
            settings.CurrentVersion = this.deltaVsCRM.CurrentVersion;

            return settings;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.deltaVsCRM.settings = GetSettings();
            this.deltaVsCRM.SaveSettings();
            this.Close();
        }
    }
}
