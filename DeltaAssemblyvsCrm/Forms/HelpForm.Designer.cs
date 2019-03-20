namespace Carfup.XTBPlugins.Forms
{
    partial class HelpForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCloseHelp = new System.Windows.Forms.Button();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.buttonOpenProjectPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCloseHelp
            // 
            this.buttonCloseHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCloseHelp.Location = new System.Drawing.Point(1509, 905);
            this.buttonCloseHelp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCloseHelp.Name = "buttonCloseHelp";
            this.buttonCloseHelp.Size = new System.Drawing.Size(138, 42);
            this.buttonCloseHelp.TabIndex = 3;
            this.buttonCloseHelp.Text = "Close";
            this.buttonCloseHelp.UseVisualStyleBackColor = true;
            this.buttonCloseHelp.Click += new System.EventHandler(this.buttonCloseHelp_Click);
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.Image = global::Carfup.XTBPlugins.Properties.Resources.helpscreenshot;
            this.pictureBoxHelp.Location = new System.Drawing.Point(22, 22);
            this.pictureBoxHelp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(1624, 871);
            this.pictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHelp.TabIndex = 5;
            this.pictureBoxHelp.TabStop = false;
            // 
            // buttonOpenProjectPage
            // 
            this.buttonOpenProjectPage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOpenProjectPage.Location = new System.Drawing.Point(22, 905);
            this.buttonOpenProjectPage.Margin = new System.Windows.Forms.Padding(6);
            this.buttonOpenProjectPage.Name = "buttonOpenProjectPage";
            this.buttonOpenProjectPage.Size = new System.Drawing.Size(361, 42);
            this.buttonOpenProjectPage.TabIndex = 6;
            this.buttonOpenProjectPage.Text = "Open Project page";
            this.buttonOpenProjectPage.UseVisualStyleBackColor = true;
            this.buttonOpenProjectPage.Click += new System.EventHandler(this.buttonOpenProjectPage_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 953);
            this.Controls.Add(this.buttonOpenProjectPage);
            this.Controls.Add(this.pictureBoxHelp);
            this.Controls.Add(this.buttonCloseHelp);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseHelp;
        private System.Windows.Forms.PictureBox pictureBoxHelp;
        private System.Windows.Forms.Button buttonOpenProjectPage;
    }
}