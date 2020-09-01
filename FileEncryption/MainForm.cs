using System;
using System.Windows.Forms;
using FileEncryptionModel.Controller;

namespace FileEncryption
{
    public partial class MainForm : Form
    {
        private EncryptionController controller;

        public MainForm()
        {
            InitializeComponent();

            controller = new EncryptionController();
        }

        private void sourceChooseButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourceBox.Text = dialog.FileName;
            }
        }

        private void destinationChooseButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                destinationBox.Text = dialog.SelectedPath;
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            //TODO: Check

            controller.Key = keyBox.Text;
            controller.SourcePath = sourceBox.Text;
            controller.DestinationPath = destinationBox.Text;

            if (controller.Encrypt())
            {
                MessageBox.Show("Done!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fail!", "Fail", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool Check()
        {
            throw new NotImplementedException();
        }
    }
}
