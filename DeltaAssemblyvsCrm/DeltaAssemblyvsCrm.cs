using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using System.Reflection;
using XrmToolBox.Extensibility.Interfaces;
using Carfup.XTBPlugins.AppCode;
using System.Diagnostics;
using Carfup.XTBPlugins.Forms;

namespace Carfup.XTBPlugins.DeltaAssemblyvsCrm
{
	public partial class DeltaAssemblyvsCrm : PluginControlBase, IGitHubPlugin
	{
		#region varibables
		public string assemblyName = "";
		private string[] listOfCRMAssemblies = null;
        private List<Entity> listOfPluginsTypesInCRM = null;
        private List<Type> listOfPluginsTypeInAssembly = null;
        private string[] inCRMButAssembly = null;
		private string[] inAssemblyButCRM = null;
        internal PluginSettings settings = new PluginSettings();
        LogUsage log = null;

        public string RepositoryName { get { return "XTBPlugins.DeltaAssemblyvsCrm"; } }

		public string UserName { get { return "carfup"; } }

		#endregion

		public DeltaAssemblyvsCrm()
		{
			InitializeComponent();
            if (tabControl1.TabPages.Contains(tabPageResult))
                tabControl1.TabPages.Remove(tabPageResult);
        }

		private void toolStripButtonLoadPluginStepsClick(object sender, EventArgs evt)
		{
			if (Service == null)
				MessageBox.Show("Please get connected to an environment first.");
			else
			{
				// we clear the content of the list first
				comboBoxAssemblyList.Items.Clear();

				WorkAsync(new WorkAsyncInfo
				{
					Message = "Loading CRM Assemblies...",
					Work = (bw, e) =>
					{
                        listOfCRMAssemblies = Service.RetrieveMultiple(new QueryExpression("pluginassembly")
						{
							ColumnSet = new ColumnSet(true),
							Criteria = new FilterExpression
							{
								Conditions =
									{
									new ConditionExpression("name", ConditionOperator.DoesNotBeginWith, "Microsoft."),
									new ConditionExpression("name", ConditionOperator.DoesNotBeginWith, "ActivityFeeds.")
									}
							}
						}).Entities.Select(p => p.GetAttributeValue<string>("name")).OrderBy(n => n).ToArray();
                    },
					PostWorkCallBack = e =>
					{
						if (e.Error != null)
						{
                            this.log.LogData(EventType.Exception, LogAction.CRMAssembliesLoaded, e.Error);
                            MessageBox.Show(this, e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}

						if (listOfCRMAssemblies != null)
						{
							comboBoxAssemblyList.Items.AddRange(listOfCRMAssemblies);
							comboBoxAssemblyList.Focus();
						}

                        this.log.LogData(EventType.Event, LogAction.CRMAssembliesLoaded);
                    },
					ProgressChanged = e => { SetWorkingMessage(e.UserState.ToString()); }
				});
			}
		}

		private void buttonLoadAssemblyClick(object sender, EventArgs e)
		{
			// we clear the content of the list first
			listBoxPluginTypesAssembly.Items.Clear();

			// opening the dialog box to select the dll
            if(openFileDialogLoadAssembly.ShowDialog() == DialogResult.OK)
            { 
			    string filepath = openFileDialogLoadAssembly.FileName;

                if (!filepath.Split('\\').Last().EndsWith(".dll"))
                {
                    MessageBox.Show(this, "Please select an assembly file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            
                labelLoadAssembly.Visible = true;
			    labelLoadAssembly.Text = $"Your assembly : {filepath.Split('\\').Last()}";           

                AppDomain domain = AppDomain.CreateDomain(labelLoadAssembly.Text);

			    System.IO.StreamReader reader = new System.IO.StreamReader(filepath, System.Text.Encoding.GetEncoding(1252), false);

			    byte[] b = new byte[reader.BaseStream.Length];
			    reader.BaseStream.Read(b, 0, System.Convert.ToInt32(reader.BaseStream.Length));

			    reader.Close();
            
			    WorkAsync(new WorkAsyncInfo
			    {
				    Message = "Loading the assembly Plugins...",
				    Work = (bw, evt) =>
				    {
                        listOfPluginsTypeInAssembly = Assembly.Load(b).GetTypes()
                        .Where(
                            t => !(t.FullName.Contains("<>c")) && // standards classes
                            (
                                t.GetInterfaces().Contains(typeof(IPlugin)) || t.GetInterfaces().Contains(typeof(IPluginExecutionContext))  // plugins
                                || (t.BaseType != null && t.BaseType.Name == "CodeActivity") // workflows
                            )
                        ).ToList();
                    },
				    PostWorkCallBack = evt =>
				    {
					    if (evt.Error != null)
					    {
                            this.log.LogData(EventType.Exception, LogAction.AssemblyLoaded, evt.Error);
                            MessageBox.Show(this, evt.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						    return;
					    }

					    if(listOfPluginsTypeInAssembly != null)
						    listBoxPluginTypesAssembly.Items.AddRange(listOfPluginsTypeInAssembly.Select(t => t.FullName).ToArray());

                        if (listViewPluginTypes.Items.Count > 0 && listBoxPluginTypesAssembly.Items.Count > 0)
                            toolStripButtonCompare.Visible = true;

                        this.log.LogData(EventType.Event, LogAction.AssemblyLoaded);
                    },
				    ProgressChanged = evt => { SetWorkingMessage(evt.UserState.ToString()); }
			    });

			    AppDomain.Unload(domain);
            }
            else
            {
                labelLoadAssembly.Text = "";
            }
        }

		private void toolStripButtonCompare_Click(object sender, EventArgs e)
		{
            if (!tabControl1.TabPages.Contains(tabPageResult))
                tabControl1.TabPages.Add(tabPageResult);

            ExecuteMethod(manageListToDisplay);
        }

		private void comboBoxAssemblyList_Changed(object sender, EventArgs evt)
		{
            // we clear the content of the list first
            listViewPluginTypes.Items.Clear();

			var assemblyname = comboBoxAssemblyList.SelectedItem.ToString();
			
			WorkAsync(new WorkAsyncInfo
			{
				Message = "Loading Plugins...",
				Work = (bw, e) =>
				{
                    
                    listOfPluginsTypesInCRM = Service.RetrieveMultiple(new QueryExpression("plugintype")
                    {
                        ColumnSet = new ColumnSet("name", "isworkflowactivity", "typename", "createdon", "modifiedon"),

                        Criteria = new FilterExpression
                        {
                            Conditions =
                            {
                                new ConditionExpression("assemblyname", ConditionOperator.Equal, assemblyname)
                            }
                        }
                    }).Entities.ToList();

                },
				PostWorkCallBack = e =>
				{
					if (e.Error != null)
					{
                        this.log.LogData(EventType.Exception, LogAction.PluginsLoaded, e.Error);
                        MessageBox.Show(this, e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

                    if (listOfPluginsTypesInCRM != null)
                    {
                        foreach(var plugin in listOfPluginsTypesInCRM)
                        { 
                            var item = new ListViewItem(plugin["name"].ToString());
                            item.SubItems.Add(plugin["createdon"].ToString());
                            item.SubItems.Add(plugin["modifiedon"].ToString());
                            item.Tag = plugin.Id;

                            listViewPluginTypes.Items.Add((ListViewItem)item.Clone());
                        }

                      //  listBoxPluginTypes.Items.AddRange(listOfPluginsTypesInCRM.Select(p => p.GetAttributeValue<string>("typename")).ToArray());
                    }
						

					if (listViewPluginTypes.Items.Count > 0 && listBoxPluginTypesAssembly.Items.Count > 0)
                        toolStripButtonCompare.Visible = true;

                    this.log.LogData(EventType.Event, LogAction.PluginsLoaded);
                },
				ProgressChanged = e => { SetWorkingMessage(e.UserState.ToString()); }
			});
		}

		private void toolStripButtonCloseTool_Click(object sender, EventArgs e)
		{
            this.log.LogData(EventType.Event, LogAction.PluginClosed);

            // Saving settings for the next usage of plugin
            SaveSettings();

            // Making sure that all message are sent if stats are enabled
            this.log.Flush();

            CloseTool();
		}

        public object returnAliasedValue(Entity entity, string varName)
        {
            return entity.GetAttributeValue<AliasedValue>(varName) == null ? "" : entity.GetAttributeValue<AliasedValue>(varName).Value;
        }

        private void checkBoxComparePlugins_CheckedChanged(object sender, EventArgs e)
        {
            ExecuteMethod(manageListToDisplay);
        }

        private void checkBoxCompareWorkflows_CheckedChanged(object sender, EventArgs e)
        {
            ExecuteMethod(manageListToDisplay);
        }

        public void manageListToDisplay()
        {
            // we clear the content of the list first
            listBoxInAssemblyButCRM.Items.Clear();
            listBoxInCRMButAssembly.Items.Clear();

            List<Entity> inCrmToCompare = new List<Entity>();
            List<Type> inAssemblyToCompare = new List<Type>();

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Comparing Plugins...",
                Work = (bw, evt) =>
                {
                    // We have at least one workflow
                    if (listOfPluginsTypeInAssembly.Where(t => t.BaseType != null && t.BaseType.Name == "CodeActivity").Count() == 0)
                    {
                        checkBoxCompareWorkflows.Checked = false;
                        checkBoxCompareWorkflows.Enabled = false;
                    }

                    // managing what to compare
                    if (checkBoxComparePlugins.Checked)
                    {
                        inCrmToCompare.AddRange(listOfPluginsTypesInCRM.Where(x => x.GetAttributeValue<bool>("isworkflowactivity") == false).ToList());
                        inAssemblyToCompare.AddRange(listOfPluginsTypeInAssembly.Where(t => t.GetInterfaces().Contains(typeof(IPlugin)) || t.GetInterfaces().Contains(typeof(IPluginExecutionContext))).ToList());
                    }
                    
                    if(checkBoxCompareWorkflows.Checked)
                    {
                        inCrmToCompare.AddRange(listOfPluginsTypesInCRM.Where(x => x.GetAttributeValue<bool>("isworkflowactivity") == true).ToList());
                        inAssemblyToCompare.AddRange(listOfPluginsTypeInAssembly.Where(t => t.BaseType != null && t.BaseType.Name == "CodeActivity").ToList());
                    }

                    inCRMButAssembly = inCrmToCompare.Select(x => x.GetAttributeValue<string>("name")).Except(inAssemblyToCompare.Select(x => x.FullName)).ToArray();
                    inAssemblyButCRM = inAssemblyToCompare.Select(x => x.FullName).Except(inCrmToCompare.Select(x => x.GetAttributeValue<string>("name"))).ToArray(); 
                },
                PostWorkCallBack = evt =>
                {
                    if (evt.Error != null)
                    {
                        this.log.LogData(EventType.Exception, LogAction.PluginsCompared, evt.Error);
                        MessageBox.Show(this, evt.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (inCRMButAssembly != null && inAssemblyButCRM != null)
                    {
                        if (inCRMButAssembly.Count() == 0)
                        {
                            listBoxInCRMButAssembly.Visible = false;
                            labelCrmButAssemblyMatch.Visible = true;
                        }
                        else
                        {
                            listBoxInCRMButAssembly.Visible = true;
                            labelCrmButAssemblyMatch.Visible = false;
                            // Pushing values to the box
                            Invoke(new Action(() => { listBoxInCRMButAssembly.Items.AddRange(inCRMButAssembly); }));
                        }

                        if (inAssemblyButCRM.Count() == 0)
                        {
                            listBoxInAssemblyButCRM.Visible = false;
                            labelAssemblyButCRMMatch.Visible = true;
                        }
                        else
                        {                            
                            listBoxInAssemblyButCRM.Visible = true;
                            labelAssemblyButCRMMatch.Visible = false;
                            // Pushing values to the box
                            Invoke(new Action(() => { listBoxInAssemblyButCRM.Items.AddRange(inAssemblyButCRM); }));
                        }

                        tabControl1.SelectedTab = tabPageResult;

                        this.log.LogData(EventType.Event, LogAction.PluginsCompared);
                    }
                },
                ProgressChanged = evt => { SetWorkingMessage(evt.UserState.ToString()); }
            });         
        }

        public void SaveSettings()
        {
            this.log.LogData(EventType.Event, LogAction.SettingsSaved);
            SettingsManager.Instance.Save(typeof(DeltaAssemblyvsCrm), settings);
        }

        private void DeltaAssemblyvsCrm_Load(object sender, EventArgs e)
        {
            log = new LogUsage(this);
            this.log.LogData(EventType.Event, LogAction.PluginOpened);
            LoadSetting();
        }
       
        private void LoadSetting()
        {
            try
            {
                if (SettingsManager.Instance.TryLoad<PluginSettings>(typeof(DeltaAssemblyvsCrm), out settings))
                {
                    return;
                }
                else
                    settings = new PluginSettings();

            }
            catch (InvalidOperationException ex)
            {
                this.log.LogData(EventType.Exception, LogAction.SettingLoaded, ex);
            }

            this.log.LogData(EventType.Event, LogAction.SettingLoaded);

            if (!settings.AllowLogUsage.HasValue)
            {
                this.log.PromptToLog();
                this.SaveSettings();
            }
        }

        public static string CurrentVersion
        {
            get
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
                return fileVersionInfo.ProductVersion;
            }
        }

        private void toolStripButtonOptions_Click(object sender, EventArgs e)
        {
            var allowLogUsage = settings.AllowLogUsage;
            var optionDlg = new Options(this);
            if (optionDlg.ShowDialog(this) == DialogResult.OK)
            {
                settings = optionDlg.GetSettings();
                if (allowLogUsage != settings.AllowLogUsage)
                {
                    if (settings.AllowLogUsage == true)
                    {
                        this.log.updateForceLog();
                        this.log.LogData(EventType.Event, LogAction.StatsAccepted);
                    }
                    else if (!settings.AllowLogUsage == true)
                    {
                        this.log.updateForceLog();
                        this.log.LogData(EventType.Event, LogAction.StatsDenied);
                    }
                }
            }
        }
    }
}
