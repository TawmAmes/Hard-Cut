namespace HardCut
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.fileFormatComboBox = new System.Windows.Forms.ComboBox();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.customTrackBar1 = new HardCut.CustomTrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.firstFrameLabel = new System.Windows.Forms.Label();
            this.lastFrameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Custom Track Bar:";
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Location = new System.Drawing.Point(12, 19);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(53, 13);
            this.inputFileLabel.TabIndex = 3;
            this.inputFileLabel.Text = "Input File:";
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(12, 55);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(61, 13);
            this.outputFileLabel.TabIndex = 4;
            this.outputFileLabel.Text = "Output File:";
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.Location = new System.Drawing.Point(95, 12);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.Size = new System.Drawing.Size(233, 20);
            this.inputFileTextBox.TabIndex = 5;
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(95, 47);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(233, 20);
            this.outputFileTextBox.TabIndex = 6;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(351, 10);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(108, 23);
            this.openFileButton.TabIndex = 7;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // fileFormatComboBox
            // 
            this.fileFormatComboBox.FormattingEnabled = true;
            this.fileFormatComboBox.Items.AddRange(new object[] {
            ".mp4",
            ".mkv",
            ".mov"});
            this.fileFormatComboBox.Location = new System.Drawing.Point(351, 47);
            this.fileFormatComboBox.Name = "fileFormatComboBox";
            this.fileFormatComboBox.Size = new System.Drawing.Size(108, 21);
            this.fileFormatComboBox.TabIndex = 8;
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(142, 503);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(498, 96);
            this.outputRichTextBox.TabIndex = 9;
            this.outputRichTextBox.Text = "";
            // 
            // customTrackBar1
            // 
            this.customTrackBar1.Location = new System.Drawing.Point(54, 424);
            this.customTrackBar1.Max = 1000;
            this.customTrackBar1.Min = 0;
            this.customTrackBar1.Name = "customTrackBar1";
            this.customTrackBar1.SelectedMax = 1000;
            this.customTrackBar1.SelectedMin = 0;
            this.customTrackBar1.Size = new System.Drawing.Size(551, 64);
            this.customTrackBar1.SliderWidth = 5;
            this.customTrackBar1.TabIndex = 10;
            this.customTrackBar1.Value = 500;
            this.customTrackBar1.AnythingChanged += new System.EventHandler(this.customTrackBar1_AnythingChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(54, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 157);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(404, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 157);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // firstFrameLabel
            // 
            this.firstFrameLabel.AutoSize = true;
            this.firstFrameLabel.Location = new System.Drawing.Point(139, 151);
            this.firstFrameLabel.Name = "firstFrameLabel";
            this.firstFrameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstFrameLabel.TabIndex = 13;
            this.firstFrameLabel.Text = "First Frame";
            // 
            // lastFrameLabel
            // 
            this.lastFrameLabel.AutoSize = true;
            this.lastFrameLabel.Location = new System.Drawing.Point(489, 151);
            this.lastFrameLabel.Name = "lastFrameLabel";
            this.lastFrameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastFrameLabel.TabIndex = 14;
            this.lastFrameLabel.Text = "Last Frame";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 627);
            this.Controls.Add(this.lastFrameLabel);
            this.Controls.Add(this.firstFrameLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customTrackBar1);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.fileFormatComboBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.inputFileTextBox);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.inputFileLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.ComboBox fileFormatComboBox;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private CustomTrackBar customTrackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label firstFrameLabel;
        private System.Windows.Forms.Label lastFrameLabel;
    }
}

