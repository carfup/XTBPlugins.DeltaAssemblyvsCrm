namespace Carfup.XTBPlugins.DeltaAssemblyvsCrm
{
	partial class DeltaAssemblyvsCrm
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeltaAssemblyvsCrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCloseTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoadPluginSteps = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCompare = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonViewSolutionsSteps = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogLoadAssembly = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLoad = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewPluginTypes = new System.Windows.Forms.ListView();
            this.columnHeaderPluginName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCreatedOn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModifiedOn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewPluginTypesAssembly = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAssemblyList = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelLoadAssembly = new System.Windows.Forms.Label();
            this.buttonLoadAssembly = new System.Windows.Forms.Button();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelCrmButAssemblyMatch = new System.Windows.Forms.Label();
            this.listViewInCRMButAssembly = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelAssemblyButCRMMatch = new System.Windows.Forms.Label();
            this.listViewInAssemblyButCRM = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBoxCompareWorkflows = new System.Windows.Forms.CheckBox();
            this.checkBoxComparePlugins = new System.Windows.Forms.CheckBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLoad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCloseTool,
            this.toolStripButtonLoadPluginSteps,
            this.toolStripButtonCompare,
            this.toolStripButtonViewSolutionsSteps,
            this.toolStripButtonOptions});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1134, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonCloseTool
            // 
            this.toolStripButtonCloseTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCloseTool.Image = global::Carfup.XTBPlugins.Properties.Resources.close;
            this.toolStripButtonCloseTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCloseTool.Name = "toolStripButtonCloseTool";
            this.toolStripButtonCloseTool.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCloseTool.Text = "toolStripButton1";
            this.toolStripButtonCloseTool.Click += new System.EventHandler(this.toolStripButtonCloseTool_Click);
            // 
            // toolStripButtonLoadPluginSteps
            // 
            this.toolStripButtonLoadPluginSteps.Image = global::Carfup.XTBPlugins.Properties.Resources.load;
            this.toolStripButtonLoadPluginSteps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadPluginSteps.Name = "toolStripButtonLoadPluginSteps";
            this.toolStripButtonLoadPluginSteps.Size = new System.Drawing.Size(144, 22);
            this.toolStripButtonLoadPluginSteps.Text = "Load CRM Assemblies";
            this.toolStripButtonLoadPluginSteps.Click += new System.EventHandler(this.toolStripButtonLoadPluginStepsClick);
            // 
            // toolStripButtonCompare
            // 
            this.toolStripButtonCompare.Image = global::Carfup.XTBPlugins.Properties.Resources.compare;
            this.toolStripButtonCompare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCompare.Name = "toolStripButtonCompare";
            this.toolStripButtonCompare.Size = new System.Drawing.Size(76, 22);
            this.toolStripButtonCompare.Text = "Compare";
            this.toolStripButtonCompare.Visible = false;
            this.toolStripButtonCompare.Click += new System.EventHandler(this.toolStripButtonCompare_Click);
            // 
            // toolStripButtonOptions
            // 
            this.toolStripButtonOptions.Image = global::Carfup.XTBPlugins.Properties.Resources.gear;
            this.toolStripButtonOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOptions.Name = "toolStripButtonOptions";
            this.toolStripButtonOptions.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonOptions.Text = "Options";
            this.toolStripButtonOptions.Click += new System.EventHandler(this.toolStripButtonOptions_Click);
            // 
            // toolStripButtonViewSolutionsSteps
            // 
            this.toolStripButtonViewSolutionsSteps.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewSolutionsSteps.Image")));
            this.toolStripButtonViewSolutionsSteps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonViewSolutionsSteps.Name = "toolStripButtonViewSolutionsSteps";
            this.toolStripButtonViewSolutionsSteps.Size = new System.Drawing.Size(136, 22);
            this.toolStripButtonViewSolutionsSteps.Text = "View solution\'s steps";
            this.toolStripButtonViewSolutionsSteps.Click += new System.EventHandler(this.toolStripButtonViewSolutionsSteps_Click);
            // 
            // openFileDialogLoadAssembly
            // 
            this.openFileDialogLoadAssembly.FileName = "openFileDialogLoadAssembly";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageLoad);
            this.tabControl1.Controls.Add(this.tabPageResult);
            this.tabControl1.Location = new System.Drawing.Point(3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 587);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageLoad
            // 
            this.tabPageLoad.Controls.Add(this.tableLayoutPanel1);
            this.tabPageLoad.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoad.Name = "tabPageLoad";
            this.tabPageLoad.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoad.Size = new System.Drawing.Size(1120, 561);
            this.tabPageLoad.TabIndex = 0;
            this.tabPageLoad.Text = "Load your stuff";
            this.tabPageLoad.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1108, 549);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.listViewPluginTypes);
            this.groupBox1.Location = new System.Drawing.Point(3, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 486);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRM Plugins list";
            // 
            // listViewPluginTypes
            // 
            this.listViewPluginTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPluginName,
            this.columnHeaderCreatedOn,
            this.columnHeaderModifiedOn});
            this.listViewPluginTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPluginTypes.Location = new System.Drawing.Point(3, 16);
            this.listViewPluginTypes.Name = "listViewPluginTypes";
            this.listViewPluginTypes.Size = new System.Drawing.Size(542, 467);
            this.listViewPluginTypes.TabIndex = 8;
            this.listViewPluginTypes.UseCompatibleStateImageBehavior = false;
            this.listViewPluginTypes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPluginName
            // 
            this.columnHeaderPluginName.Text = "Plugin Name";
            this.columnHeaderPluginName.Width = 200;
            // 
            // columnHeaderCreatedOn
            // 
            this.columnHeaderCreatedOn.DisplayIndex = 2;
            this.columnHeaderCreatedOn.Text = "Created On";
            this.columnHeaderCreatedOn.Width = 112;
            // 
            // columnHeaderModifiedOn
            // 
            this.columnHeaderModifiedOn.DisplayIndex = 1;
            this.columnHeaderModifiedOn.Text = "Modified On";
            this.columnHeaderModifiedOn.Width = 93;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.listViewPluginTypesAssembly);
            this.groupBox2.Location = new System.Drawing.Point(557, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 486);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assembly Plugins list";
            // 
            // listViewPluginTypesAssembly
            // 
            this.listViewPluginTypesAssembly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewPluginTypesAssembly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPluginTypesAssembly.Location = new System.Drawing.Point(3, 16);
            this.listViewPluginTypesAssembly.Name = "listViewPluginTypesAssembly";
            this.listViewPluginTypesAssembly.Size = new System.Drawing.Size(542, 467);
            this.listViewPluginTypesAssembly.TabIndex = 9;
            this.listViewPluginTypesAssembly.UseCompatibleStateImageBehavior = false;
            this.listViewPluginTypesAssembly.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plugin Name";
            this.columnHeader1.Width = 200;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.comboBoxAssemblyList);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(548, 51);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CRM Assembly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select your CRM Assembly:";
            // 
            // comboBoxAssemblyList
            // 
            this.comboBoxAssemblyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAssemblyList.FormattingEnabled = true;
            this.comboBoxAssemblyList.Location = new System.Drawing.Point(153, 19);
            this.comboBoxAssemblyList.Name = "comboBoxAssemblyList";
            this.comboBoxAssemblyList.Size = new System.Drawing.Size(329, 21);
            this.comboBoxAssemblyList.TabIndex = 11;
            this.comboBoxAssemblyList.SelectedIndexChanged += new System.EventHandler(this.comboBoxAssemblyList_Changed);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.labelLoadAssembly);
            this.groupBox6.Controls.Add(this.buttonLoadAssembly);
            this.groupBox6.Location = new System.Drawing.Point(557, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(548, 51);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Local Assembly";
            // 
            // labelLoadAssembly
            // 
            this.labelLoadAssembly.AutoSize = true;
            this.labelLoadAssembly.Location = new System.Drawing.Point(186, 22);
            this.labelLoadAssembly.Name = "labelLoadAssembly";
            this.labelLoadAssembly.Size = new System.Drawing.Size(35, 13);
            this.labelLoadAssembly.TabIndex = 9;
            this.labelLoadAssembly.Text = "label2";
            this.labelLoadAssembly.Visible = false;
            // 
            // buttonLoadAssembly
            // 
            this.buttonLoadAssembly.Location = new System.Drawing.Point(6, 16);
            this.buttonLoadAssembly.Name = "buttonLoadAssembly";
            this.buttonLoadAssembly.Size = new System.Drawing.Size(165, 23);
            this.buttonLoadAssembly.TabIndex = 8;
            this.buttonLoadAssembly.Text = "Load your local assembly";
            this.buttonLoadAssembly.UseVisualStyleBackColor = true;
            this.buttonLoadAssembly.Click += new System.EventHandler(this.buttonLoadAssemblyClick);
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.tableLayoutPanel2);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(1120, 561);
            this.tabPageResult.TabIndex = 1;
            this.tabPageResult.Text = "See the result";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1096, 549);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.labelCrmButAssemblyMatch);
            this.groupBox3.Controls.Add(this.listViewInCRMButAssembly);
            this.groupBox3.Location = new System.Drawing.Point(3, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 500);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plugins which are in your CRM but not in your assembly";
            // 
            // labelCrmButAssemblyMatch
            // 
            this.labelCrmButAssemblyMatch.AutoSize = true;
            this.labelCrmButAssemblyMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrmButAssemblyMatch.ForeColor = System.Drawing.Color.Green;
            this.labelCrmButAssemblyMatch.Location = new System.Drawing.Point(109, 97);
            this.labelCrmButAssemblyMatch.Name = "labelCrmButAssemblyMatch";
            this.labelCrmButAssemblyMatch.Size = new System.Drawing.Size(302, 31);
            this.labelCrmButAssemblyMatch.TabIndex = 17;
            this.labelCrmButAssemblyMatch.Text = "This is a perfect match !";
            this.labelCrmButAssemblyMatch.Visible = false;
            // 
            // listViewInCRMButAssembly
            // 
            this.listViewInCRMButAssembly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewInCRMButAssembly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInCRMButAssembly.Location = new System.Drawing.Point(3, 16);
            this.listViewInCRMButAssembly.Name = "listViewInCRMButAssembly";
            this.listViewInCRMButAssembly.Size = new System.Drawing.Size(536, 481);
            this.listViewInCRMButAssembly.TabIndex = 16;
            this.listViewInCRMButAssembly.UseCompatibleStateImageBehavior = false;
            this.listViewInCRMButAssembly.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Plugin Name";
            this.columnHeader2.Width = 181;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.labelAssemblyButCRMMatch);
            this.groupBox4.Controls.Add(this.listViewInAssemblyButCRM);
            this.groupBox4.Location = new System.Drawing.Point(551, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 500);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plugins which are in your assembly but not in your CRM";
            // 
            // labelAssemblyButCRMMatch
            // 
            this.labelAssemblyButCRMMatch.AutoSize = true;
            this.labelAssemblyButCRMMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssemblyButCRMMatch.ForeColor = System.Drawing.Color.Green;
            this.labelAssemblyButCRMMatch.Location = new System.Drawing.Point(120, 97);
            this.labelAssemblyButCRMMatch.Name = "labelAssemblyButCRMMatch";
            this.labelAssemblyButCRMMatch.Size = new System.Drawing.Size(302, 31);
            this.labelAssemblyButCRMMatch.TabIndex = 19;
            this.labelAssemblyButCRMMatch.Text = "This is a perfect match !";
            this.labelAssemblyButCRMMatch.Visible = false;
            // 
            // listViewInAssemblyButCRM
            // 
            this.listViewInAssemblyButCRM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewInAssemblyButCRM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInAssemblyButCRM.Location = new System.Drawing.Point(3, 16);
            this.listViewInAssemblyButCRM.Name = "listViewInAssemblyButCRM";
            this.listViewInAssemblyButCRM.Size = new System.Drawing.Size(536, 481);
            this.listViewInAssemblyButCRM.TabIndex = 18;
            this.listViewInAssemblyButCRM.UseCompatibleStateImageBehavior = false;
            this.listViewInAssemblyButCRM.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Plugin Name";
            this.columnHeader3.Width = 181;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.checkBoxCompareWorkflows);
            this.groupBox7.Controls.Add(this.checkBoxComparePlugins);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(542, 37);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "What to compare ?";
            // 
            // checkBoxCompareWorkflows
            // 
            this.checkBoxCompareWorkflows.AutoSize = true;
            this.checkBoxCompareWorkflows.Checked = true;
            this.checkBoxCompareWorkflows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCompareWorkflows.Location = new System.Drawing.Point(208, 14);
            this.checkBoxCompareWorkflows.Name = "checkBoxCompareWorkflows";
            this.checkBoxCompareWorkflows.Size = new System.Drawing.Size(76, 17);
            this.checkBoxCompareWorkflows.TabIndex = 1;
            this.checkBoxCompareWorkflows.Text = "Workflows";
            this.checkBoxCompareWorkflows.UseVisualStyleBackColor = true;
            this.checkBoxCompareWorkflows.CheckedChanged += new System.EventHandler(this.checkBoxCompareWorkflows_CheckedChanged);
            // 
            // checkBoxComparePlugins
            // 
            this.checkBoxComparePlugins.AutoSize = true;
            this.checkBoxComparePlugins.Checked = true;
            this.checkBoxComparePlugins.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxComparePlugins.Location = new System.Drawing.Point(115, 14);
            this.checkBoxComparePlugins.Name = "checkBoxComparePlugins";
            this.checkBoxComparePlugins.Size = new System.Drawing.Size(60, 17);
            this.checkBoxComparePlugins.TabIndex = 0;
            this.checkBoxComparePlugins.Text = "Plugins";
            this.checkBoxComparePlugins.UseVisualStyleBackColor = true;
            this.checkBoxComparePlugins.CheckedChanged += new System.EventHandler(this.checkBoxComparePlugins_CheckedChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // DeltaAssemblyvsCrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DeltaAssemblyvsCrm";
            this.Size = new System.Drawing.Size(1134, 618);
            this.Load += new System.EventHandler(this.DeltaAssemblyvsCrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLoad.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPageResult.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonLoadPluginSteps;
		private System.Windows.Forms.OpenFileDialog openFileDialogLoadAssembly;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageLoad;
		private System.Windows.Forms.TabPage tabPageResult;
		private System.Windows.Forms.ToolStripButton toolStripButtonCompare;
		private System.Windows.Forms.ToolStripButton toolStripButtonCloseTool;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAssemblyList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelLoadAssembly;
        private System.Windows.Forms.Button buttonLoadAssembly;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBoxCompareWorkflows;
        private System.Windows.Forms.CheckBox checkBoxComparePlugins;
        private System.Windows.Forms.ToolStripButton toolStripButtonOptions;
        private System.Windows.Forms.ListView listViewPluginTypes;
        private System.Windows.Forms.ColumnHeader columnHeaderPluginName;
        private System.Windows.Forms.ColumnHeader columnHeaderCreatedOn;
        private System.Windows.Forms.ColumnHeader columnHeaderModifiedOn;
        private System.Windows.Forms.ListView listViewPluginTypesAssembly;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label labelCrmButAssemblyMatch;
        private System.Windows.Forms.ListView listViewInCRMButAssembly;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelAssemblyButCRMMatch;
        private System.Windows.Forms.ListView listViewInAssemblyButCRM;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewSolutionsSteps;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
