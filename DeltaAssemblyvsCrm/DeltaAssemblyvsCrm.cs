using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using System.Reflection;
using System.Web.UI.WebControls;
using System.IO;
using XrmToolBox.Extensibility.Interfaces;

namespace Carfup.XTBPlugins.DeltaAssemblyvsCrm
{
	public partial class DeltaAssemblyvsCrm : PluginControlBase, IGitHubPlugin
	{
		#region varibables
		public string assemblyName = "";
		private string[] listOfCRMAssemblies = null;
		private string[] listOfPluginsInCRM = null;
		private string[] listOfPluginsInAssembly = null;
		private string[] inCRMButAssembly = null;
		private string[] inAssemblyButCRM = null;

		public string RepositoryName
		{
			get
			{
				return "XTBPlugins.DeltaAssemblyvsCrm";
			}
		}

		public string UserName
		{
			get
			{
				return "carfup";
			}
		}

		#endregion

		public DeltaAssemblyvsCrm()
		{
			InitializeComponent();			
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
						}).Entities.Select(p => p.Attributes["name"].ToString()).ToArray();
					},
					PostWorkCallBack = e =>
					{
						if (e.Error != null)
						{
							MessageBox.Show(this, e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}

						if (listOfCRMAssemblies != null)
						{
							comboBoxAssemblyList.Items.AddRange(listOfCRMAssemblies);
							comboBoxAssemblyList.Focus();
						}
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
			openFileDialogLoadAssembly.ShowDialog();
			string filepath = openFileDialogLoadAssembly.FileName;
			labelLoadAssembly.Visible = true;
			labelLoadAssembly.Text = $"Your assembly : {filepath.Split('\\').Last()}";

			AppDomain domain = AppDomain.CreateDomain(labelLoadAssembly.Text);

			System.IO.StreamReader reader = new System.IO.StreamReader(filepath, System.Text.Encoding.GetEncoding(1252), false);

			byte[] b = new byte[reader.BaseStream.Length];
			reader.BaseStream.Read(b, 0, System.Convert.ToInt32(reader.BaseStream.Length));

			reader.Close();


			WorkAsync(new WorkAsyncInfo
			{
				Message = "loading the assembly Plugins...",
				Work = (bw, evt) =>
				{
					listOfPluginsInAssembly = Assembly.Load(b).GetTypes()
					.Where(t => !(t.FullName.Contains("<>c")) && (t.GetInterfaces().Contains(typeof(IPlugin)) || t.GetInterfaces().Contains(typeof(IPluginExecutionContext))))
					.Select(t => t.FullName)
					.ToArray();

					
					
				},
				PostWorkCallBack = evt =>
				{
					if (evt.Error != null)
					{
						MessageBox.Show(this, evt.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if(listOfPluginsInAssembly != null)
						listBoxPluginTypesAssembly.Items.AddRange(listOfPluginsInAssembly);

					if (listBoxPluginTypes.Items.Count > 0 && listBoxPluginTypesAssembly.Items.Count > 0)
						toolStripButtonCompare.Visible = true;
				},
				ProgressChanged = evt => { SetWorkingMessage(evt.UserState.ToString()); }
			});

			AppDomain.Unload(domain);
		}

		private void toolStripButtonCompare_Click(object sender, EventArgs e)
		{
			// we clear the content of the list first
			listBoxInAssemblyButCRM.Items.Clear();
			listBoxInCRMButAssembly.Items.Clear();

			WorkAsync(new WorkAsyncInfo
			{
				Message = "Comparing Plugins...",
				Work = (bw, evt) =>
				{
					inCRMButAssembly = listOfPluginsInCRM.Except(listOfPluginsInAssembly).ToArray();
					inAssemblyButCRM = listOfPluginsInAssembly.Except(listOfPluginsInCRM).ToArray();

					
				},
				PostWorkCallBack = evt =>
				{
					if (evt.Error != null)
					{
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
							listBoxInCRMButAssembly.Items.AddRange(inCRMButAssembly);
							labelCrmButAssemblyMatch.Visible = false;

						}

						if (inAssemblyButCRM.Count() == 0)
						{
							listBoxInAssemblyButCRM.Visible = false;
							labelAssemblyButCRMMatch.Visible = true;
						}
						else
						{
							listBoxInAssemblyButCRM.Items.AddRange(inAssemblyButCRM);
							listBoxInAssemblyButCRM.Visible = true;
							labelAssemblyButCRMMatch.Visible = false;
						}
						tabControl1.SelectedTab = tabPageResult;
					}
				},
				ProgressChanged = evt => { SetWorkingMessage(evt.UserState.ToString()); }
			});
		}

		private void comboBoxAssemblyList_Changed(object sender, EventArgs evt)
		{
			// we clear the content of the list first
			listBoxPluginTypes.Items.Clear();

			var assemblyname = comboBoxAssemblyList.SelectedItem.ToString();
			
			WorkAsync(new WorkAsyncInfo
			{
				Message = "Loading Plugins...",
				Work = (bw, e) =>
				{
				listOfPluginsInCRM = Service.RetrieveMultiple(new QueryExpression("plugintype")
				{
					ColumnSet = new ColumnSet(true),
					Criteria = new FilterExpression
					{
						Conditions =
								{
									new ConditionExpression("assemblyname", ConditionOperator.Equal, assemblyname)
								}
						}
					}).Entities.Select(p => p.Attributes["typename"].ToString()).ToArray();
				},
				PostWorkCallBack = e =>
				{
					if (e.Error != null)
					{
						MessageBox.Show(this, e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (listOfPluginsInCRM != null)
						listBoxPluginTypes.Items.AddRange(listOfPluginsInCRM);

					if (listBoxPluginTypes.Items.Count > 0 && listBoxPluginTypesAssembly.Items.Count > 0)
						toolStripButtonCompare.Visible = true;
				},
				ProgressChanged = e => { SetWorkingMessage(e.UserState.ToString()); }
			});
		}

		private void toolStripButtonCloseTool_Click(object sender, EventArgs e)
		{
			CloseTool();
		}
	}
}
