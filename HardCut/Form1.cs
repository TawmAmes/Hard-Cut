using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HardCut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            var fileString = ofd.ShowDialog().ToString();

            if (fileString == "OK")
            {
                var filePath = ofd.FileName;
                var fileName = Path.GetFileName(filePath);
                var fileNameNoExt = Path.GetFileNameWithoutExtension(filePath);
                var filePathNoName = ofd.FileName.Except(fileName); //not used

                inputFileTextBox.Text = fileName;
                outputFileTextBox.Text = fileNameNoExt;

                //allow user to change output file name immediately
                outputFileTextBox.SelectAll();
                outputFileTextBox.Focus();
            }
        }

        private void customTrackBar1_AnythingChanged(object sender, EventArgs e)
        {
            outputRichTextBox.Text = String.Format("{0}\t{1}\t{2}",
                customTrackBar1.SelectedMin.ToString(),
                customTrackBar1.Value.ToString(),
                customTrackBar1.SelectedMax.ToString());
        }
    }
}
