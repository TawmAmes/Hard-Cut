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
using System.Diagnostics;
using System.Threading;

namespace HardCut
{
    public partial class Form1 : Form
    {

        //Global Variables
        private bool fileSelected = false;
        private string filePath;
        private string fileName;
        
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
                filePath = ofd.FileName;
                fileName = Path.GetFileName(filePath);
                var fileNameNoExt = Path.GetFileNameWithoutExtension(filePath);
                var filePathNoName = ofd.FileName.Except(fileName); //not used
                fileSelected = true;

                inputFileTextBox.Text = fileName;
                outputFileTextBox.Text = fileNameNoExt;

                //allow user to change output file name immediately
                outputFileTextBox.SelectAll();
                outputFileTextBox.Focus();

                if(fileSelected)
                {
                    //gatherFrames();
                }
            }
        }

        private void customTrackBar1_AnythingChanged(object sender, EventArgs e)
        {
            outputRichTextBox.Text = customTrackBar1.AllValues();
        }

        private void gatherFrames()
        {
            //TODO: use the FFMpeg code to gather frames at X and Y times;
            //https://stackoverflow.com/questions/1707516/c-sharp-and-ffmpeg-preferably-without-shell-commands

            Process process = new Process();
            process.StartInfo.FileName = "ffmpeg";
            process.StartInfo.Arguments = "-i " + filePath;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            if (!process.Start())
            {
                Console.WriteLine("Error starting");
                return;
            }
            StreamReader reader = process.StandardError;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                outputRichTextBox.AppendText(line + "\n");
            }
            process.Close();

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //need to account for framerate
            int startTime = customTrackBar1.SelectedMin;
            int endTime = customTrackBar1.SelectedMax;

            outputRichTextBox.ResetText();
            Process process = new Process();
            string resultLine;

            process.StartInfo.FileName = "ffmpeg";
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;

            //this line is breaking for some reason
            /*
            process.StartInfo.Arguments = "ffprobe -v 0 - of compact=p=0 -select_streams 0 \\ -show_entries stream=r_frame_rate " + fileName;
            if (!process.Start())
            {
                Console.WriteLine("Error starting");
                return;
            }
            StreamReader reader = process.StandardError;
            while ((resultLine = reader.ReadLine()) != null)
            {
                outputRichTextBox.AppendText("FRAME_RATE:\t" + resultLine + "\n");
            }
            var frameRate = resultLine;
            */
            

            var frameRate = 60;
            TimeSpan t = TimeSpan.FromSeconds(startTime * frameRate);
            string tFrameRate = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);

            //process.Refresh(); //************************************************

            //getting image of first frame
            process.StartInfo.Arguments = "-ss " + tFrameRate + " -i " + filePath + " -vframes 1 -q:v 2 output1.jpg -y"; //-y to "yes" overwrite
            if (!process.Start())
            {
                Console.WriteLine("Error starting");
                return;
            }
            StreamReader reader = process.StandardError;
            while ((resultLine = reader.ReadLine()) != null)
            {
                outputRichTextBox.AppendText("FIRST_FRAME_IMAGE:\t" + resultLine + "\n");
            }
            var firstFrameImage = resultLine;
            pictureBox1.ImageLocation = "output1.jpg";

            //getting image of last frame
            process.StartInfo.Arguments = "-ss " + endTime /*frameRate*/ + " -i " + filePath + " -vframes 1 -q:v 2 output2.jpg -y";
            if (!process.Start())
            {
                Console.WriteLine("Error starting");
                return;
            }
            while ((resultLine = reader.ReadLine()) != null)
            {
                outputRichTextBox.AppendText("LAST_FRAME_IMAGE:\t" + resultLine + "\n");
            }
            var lastFrameImage = resultLine;
            pictureBox2.ImageLocation = "output2.jpg";


            //process.StartInfo.Arguments = "-i " + filePath + " " + outputFileTextBox.Text + fileFormatComboBox.SelectedText;
            //ffmpeg - ss 36:00 - i "missed headshot.mkv" - map 0 - c copy - t 15 "missed headshot.mp4"
            process.StartInfo.Arguments = "-ss " + startTime.ToString() + " -i " + fileName + " -map 0 -c copy -t " + (endTime - startTime).ToString() + " " + outputFileTextBox + fileFormatComboBox.SelectedText;
            if (!process.Start())
            {
                Console.WriteLine("Error starting");
                return;
            }
            while ((resultLine = reader.ReadLine()) != null)
            {
                outputRichTextBox.AppendText(resultLine + "\n");
            }
            process.Close();
        }
    }
}
