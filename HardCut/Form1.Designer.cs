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
            this.customTrackBarLabel = new System.Windows.Forms.Label();
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.fileFormatComboBox = new System.Windows.Forms.ComboBox();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.firstFrameLabel = new System.Windows.Forms.Label();
            this.lastFrameLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.customTrackBar1 = new HardCut.CustomTrackBar();
            this.toolboxCustomTrackBar1 = new HardCut.ToolboxCustomTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // customTrackBarLabel
            // 
            this.customTrackBarLabel.AutoSize = true;
            this.customTrackBarLabel.Location = new System.Drawing.Point(29, 385);
            this.customTrackBarLabel.Name = "customTrackBarLabel";
            this.customTrackBarLabel.Size = new System.Drawing.Size(95, 13);
            this.customTrackBarLabel.TabIndex = 2;
            this.customTrackBarLabel.Text = "Custom Track Bar:";
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
            this.inputFileTextBox.TabIndex = 1;
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
            this.fileFormatComboBox.Text = ".mp4";
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(32, 664);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(551, 96);
            this.outputRichTextBox.TabIndex = 9;
            this.outputRichTextBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(54, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 135);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(404, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 135);
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
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(32, 625);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 15;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // customTrackBar1
            // 
            this.customTrackBar1.Location = new System.Drawing.Point(46, 416);
            this.customTrackBar1.Max = 1000;
            this.customTrackBar1.Min = 0;
            this.customTrackBar1.Name = "customTrackBar1";
            this.customTrackBar1.SelectedMax = 1000;
            this.customTrackBar1.SelectedMin = 0;
            this.customTrackBar1.Size = new System.Drawing.Size(743, 80);
            this.customTrackBar1.SliderWidth = 2;
            this.customTrackBar1.TabIndex = 17;
            this.customTrackBar1.Value = 500;
            // 
            // toolboxCustomTrackBar1
            // 
            this.toolboxCustomTrackBar1.LabelHeight = 10;
            this.toolboxCustomTrackBar1.Location = new System.Drawing.Point(44, 516);
            this.toolboxCustomTrackBar1.Max = 1000;
            this.toolboxCustomTrackBar1.Min = 0;
            this.toolboxCustomTrackBar1.Name = "toolboxCustomTrackBar1";
            this.toolboxCustomTrackBar1.SelectedMax = 1000;
            this.toolboxCustomTrackBar1.SelectedMin = 0;
            this.toolboxCustomTrackBar1.SelectedValue = 500;
            this.toolboxCustomTrackBar1.Size = new System.Drawing.Size(836, 95);
            this.toolboxCustomTrackBar1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 769);
            this.Controls.Add(this.toolboxCustomTrackBar1);
            this.Controls.Add(this.customTrackBar1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.lastFrameLabel);
            this.Controls.Add(this.firstFrameLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.fileFormatComboBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.inputFileTextBox);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.inputFileLabel);
            this.Controls.Add(this.customTrackBarLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label customTrackBarLabel;
        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.ComboBox fileFormatComboBox;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label firstFrameLabel;
        private System.Windows.Forms.Label lastFrameLabel;
        private System.Windows.Forms.Button convertButton;
        private CustomTrackBar customTrackBar1;
        private ToolboxCustomTrackBar toolboxCustomTrackBar1;
    }
}

