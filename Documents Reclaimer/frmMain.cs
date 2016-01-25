using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;

namespace Documents_Reclaimer
{
    public partial class frmMain : Form
    {
        private string _OriginalDirectory;

        public frmMain(string directory)
        {
            InitializeComponent();
            _OriginalDirectory = directory;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pbFolderIcon.Image = Win32.GetFolderIcon(_OriginalDirectory, IconSize.Large, FolderType.Open).ToBitmap();
            txtDirectory.Text = _OriginalDirectory;

        }

        private void btnFindTarget_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", txtDirectory.Text);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            var dialog = new FolderSelectDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "Select a Destination"
            };
            if (dialog.Show(Handle))
            {
                txtDirectory.Text = dialog.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var prompt = string.Format("Please confirm your changes below.\n\nOld Path: {0}\nNew Path: {1}", _OriginalDirectory, txtDirectory.Text);
            var result = MessageBox.Show(prompt, "Confirm Folder Move", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                try
                {
                    FileSystem.CopyDirectory(_OriginalDirectory, txtDirectory.Text, UIOption.AllDialogs);
                }
                catch (OperationCanceledException)
                {
                    //do nothing                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error moving files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Delete the original folder
                try
                {
                    Directory.Delete(_OriginalDirectory, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting original folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Create Junction
                try
                {
                    JunctionPoint.Create(_OriginalDirectory, txtDirectory.Text, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error creating junction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Hide junction
                File.SetAttributes(_OriginalDirectory, File.GetAttributes(_OriginalDirectory) | FileAttributes.Hidden | FileAttributes.System);

            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Not Implemented Yet", "Documents Reclaimer");
        }
    }
}
