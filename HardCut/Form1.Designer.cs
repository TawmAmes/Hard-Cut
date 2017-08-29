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
            this.customTrackBar1 = new HardCut.CustomTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customTrackBar1
            // 
            this.customTrackBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.customTrackBar1.Location = new System.Drawing.Point(32, 415);
            this.customTrackBar1.Max = 100;
            this.customTrackBar1.Min = 0;
            this.customTrackBar1.Name = "customTrackBar1";
            this.customTrackBar1.SelectedMax = 100;
            this.customTrackBar1.SelectedMin = 0;
            this.customTrackBar1.Size = new System.Drawing.Size(719, 67);
            this.customTrackBar1.TabIndex = 1;
            this.customTrackBar1.Value = 50;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customTrackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomTrackBar customTrackBar1;
        private System.Windows.Forms.Label label1;
    }
}

