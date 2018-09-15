using System;
using System.Windows.Forms;

namespace EmbeddedResourceExtractor
{
    public partial class MainForm : Form
    {
        private AssemblyHelper assemblyHelper;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            var assemblyPath = textBoxAssemblyFile.Text;
            if (string.IsNullOrWhiteSpace(assemblyPath) || !System.IO.File.Exists(assemblyPath))
            {
                if (openFileDialogAssembly.ShowDialog() != DialogResult.OK)
                    return;
                assemblyPath = openFileDialogAssembly.FileName;
                textBoxAssemblyFile.Text = assemblyPath;
            }

            listBoxResourceNames.Items.Clear();
            buttonExport.Enabled = false;
            assemblyHelper = new AssemblyHelper(assemblyPath);
            if (!assemblyHelper.IsValid)
            {
                MessageBox.Show(assemblyHelper.ErrorDescription,
                    "Not a valid Assembly",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                assemblyHelper = null;
                return;
            }

            listBoxResourceNames.Items.AddRange(assemblyHelper.ListResourceNames());
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            if (assemblyHelper == null || !assemblyHelper.IsValid)
                return;

            if (folderBrowserDialogExportTarget.ShowDialog() != DialogResult.OK)
                return;

            var targetFolderPath = folderBrowserDialogExportTarget.SelectedPath;
            foreach (var resourceName in listBoxResourceNames.SelectedItems)
            {
                try
                {
                    assemblyHelper.WriteResourceToFile((string)resourceName, targetFolderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to export",
                        string.Format("Failed to export \"{0}\":\n{1}", resourceName, ex.Message),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void ListBoxResourceNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonExport.Enabled = listBoxResourceNames.SelectedItems.Count > 0;
        }
    }
}
