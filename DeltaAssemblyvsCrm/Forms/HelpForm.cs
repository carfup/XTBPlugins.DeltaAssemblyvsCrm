using Carfup.XTBPlugins.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carfup.XTBPlugins.Forms
{
    public partial class HelpForm : Form
    {
        private DeltaAssemblyvsCrm.DeltaAssemblyvsCrm dac;
        public HelpForm(DeltaAssemblyvsCrm.DeltaAssemblyvsCrm dac)
        {
            InitializeComponent();
            this.dac = dac;
            this.dac.log.LogData(EventType.Event, LogAction.ShowHelpScreen);
        }

        private void buttonCloseHelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpenProjectPage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/carfup/XTBPlugins.DeltaAssemblyvsCrm/");
        }
    }
}
