namespace EmbeddedResourceExtractor
{
    partial class MainForm
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
            this.textBoxAssemblyFile = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.openFileDialogAssembly = new System.Windows.Forms.OpenFileDialog();
            this.listBoxResourceNames = new System.Windows.Forms.ListBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.folderBrowserDialogExportTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBoxAssemblyFile
            // 
            this.textBoxAssemblyFile.Location = new System.Drawing.Point(12, 12);
            this.textBoxAssemblyFile.Name = "textBoxAssemblyFile";
            this.textBoxAssemblyFile.Size = new System.Drawing.Size(471, 20);
            this.textBoxAssemblyFile.TabIndex = 0;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(489, 10);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // openFileDialogAssembly
            // 
            this.openFileDialogAssembly.FileName = "openFileDialog1";
            this.openFileDialogAssembly.Filter = "Assemblies|*.exe;*.dll";
            // 
            // listBoxResourceNames
            // 
            this.listBoxResourceNames.FormattingEnabled = true;
            this.listBoxResourceNames.Location = new System.Drawing.Point(12, 38);
            this.listBoxResourceNames.Name = "listBoxResourceNames";
            this.listBoxResourceNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxResourceNames.Size = new System.Drawing.Size(552, 264);
            this.listBoxResourceNames.TabIndex = 2;
            this.listBoxResourceNames.SelectedIndexChanged += new System.EventHandler(this.ListBoxResourceNames_SelectedIndexChanged);
            // 
            // buttonExport
            // 
            this.buttonExport.Enabled = false;
            this.buttonExport.Location = new System.Drawing.Point(489, 309);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "Export...";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 344);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.listBoxResourceNames);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxAssemblyFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EmbeddedResourceExtractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAssemblyFile;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialogAssembly;
        private System.Windows.Forms.ListBox listBoxResourceNames;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogExportTarget;
    }
}

