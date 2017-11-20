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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCloseTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoadPluginSteps = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCompare = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogLoadAssembly = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLoad = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxPluginTypes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxPluginTypesAssembly = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAssemblyList = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelLoadAssembly = new System.Windows.Forms.Label();
            this.buttonLoadAssembly = new System.Windows.Forms.Button();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelAssemblyButCRMMatch = new System.Windows.Forms.Label();
            this.listBoxInAssemblyButCRM = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelCrmButAssemblyMatch = new System.Windows.Forms.Label();
            this.listBoxInCRMButAssembly = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLoad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCloseTool,
            this.toolStripButtonLoadPluginSteps,
            this.toolStripButtonCompare});
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
            this.groupBox1.Controls.Add(this.listBoxPluginTypes);
            this.groupBox1.Location = new System.Drawing.Point(3, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 486);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRM Plugins list";
            // 
            // listBoxPluginTypes
            // 
            this.listBoxPluginTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPluginTypes.FormattingEnabled = true;
            this.listBoxPluginTypes.Location = new System.Drawing.Point(9, 17);
            this.listBoxPluginTypes.Name = "listBoxPluginTypes";
            this.listBoxPluginTypes.Size = new System.Drawing.Size(533, 446);
            this.listBoxPluginTypes.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.listBoxPluginTypesAssembly);
            this.groupBox2.Location = new System.Drawing.Point(557, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 486);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assembly Plugins list";
            // 
            // listBoxPluginTypesAssembly
            // 
            this.listBoxPluginTypesAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPluginTypesAssembly.FormattingEnabled = true;
            this.listBoxPluginTypesAssembly.Location = new System.Drawing.Point(6, 17);
            this.listBoxPluginTypesAssembly.Name = "listBoxPluginTypesAssembly";
            this.listBoxPluginTypesAssembly.Size = new System.Drawing.Size(536, 446);
            this.listBoxPluginTypesAssembly.TabIndex = 9;
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
            this.label4.Location = new System.Drawing.Point(6, 16);
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
            this.comboBoxAssemblyList.Location = new System.Drawing.Point(155, 12);
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
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.labelAssemblyButCRMMatch);
            this.groupBox4.Controls.Add(this.listBoxInAssemblyButCRM);
            this.groupBox4.Location = new System.Drawing.Point(551, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 543);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plugins which are in your assembly but not in your CRM";
            // 
            // labelAssemblyButCRMMatch
            // 
            this.labelAssemblyButCRMMatch.AutoSize = true;
            this.labelAssemblyButCRMMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssemblyButCRMMatch.ForeColor = System.Drawing.Color.Green;
            this.labelAssemblyButCRMMatch.Location = new System.Drawing.Point(116, 97);
            this.labelAssemblyButCRMMatch.Name = "labelAssemblyButCRMMatch";
            this.labelAssemblyButCRMMatch.Size = new System.Drawing.Size(302, 31);
            this.labelAssemblyButCRMMatch.TabIndex = 16;
            this.labelAssemblyButCRMMatch.Text = "This is a perfect match !";
            this.labelAssemblyButCRMMatch.Visible = false;
            // 
            // listBoxInAssemblyButCRM
            // 
            this.listBoxInAssemblyButCRM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxInAssemblyButCRM.FormattingEnabled = true;
            this.listBoxInAssemblyButCRM.Location = new System.Drawing.Point(6, 19);
            this.listBoxInAssemblyButCRM.Name = "listBoxInAssemblyButCRM";
            this.listBoxInAssemblyButCRM.Size = new System.Drawing.Size(530, 511);
            this.listBoxInAssemblyButCRM.TabIndex = 2;
            this.listBoxInAssemblyButCRM.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.labelCrmButAssemblyMatch);
            this.groupBox3.Controls.Add(this.listBoxInCRMButAssembly);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 543);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plugins which are in your CRM but not in your assembly";
            // 
            // labelCrmButAssemblyMatch
            // 
            this.labelCrmButAssemblyMatch.AutoSize = true;
            this.labelCrmButAssemblyMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrmButAssemblyMatch.ForeColor = System.Drawing.Color.Green;
            this.labelCrmButAssemblyMatch.Location = new System.Drawing.Point(79, 97);
            this.labelCrmButAssemblyMatch.Name = "labelCrmButAssemblyMatch";
            this.labelCrmButAssemblyMatch.Size = new System.Drawing.Size(302, 31);
            this.labelCrmButAssemblyMatch.TabIndex = 15;
            this.labelCrmButAssemblyMatch.Text = "This is a perfect match !";
            this.labelCrmButAssemblyMatch.Visible = false;
            // 
            // listBoxInCRMButAssembly
            // 
            this.listBoxInCRMButAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxInCRMButAssembly.FormattingEnabled = true;
            this.listBoxInCRMButAssembly.Location = new System.Drawing.Point(6, 19);
            this.listBoxInCRMButAssembly.Name = "listBoxInCRMButAssembly";
            this.listBoxInCRMButAssembly.Size = new System.Drawing.Size(512, 511);
            this.listBoxInCRMButAssembly.TabIndex = 14;
            this.listBoxInCRMButAssembly.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1096, 549);
            this.tableLayoutPanel2.TabIndex = 16;
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
		private System.Windows.Forms.ListBox listBoxPluginTypesAssembly;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBoxPluginTypes;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListBox listBoxInAssemblyButCRM;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox listBoxInCRMButAssembly;
		private System.Windows.Forms.Label labelAssemblyButCRMMatch;
		private System.Windows.Forms.Label labelCrmButAssemblyMatch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAssemblyList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelLoadAssembly;
        private System.Windows.Forms.Button buttonLoadAssembly;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
