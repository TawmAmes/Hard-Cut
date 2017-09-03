namespace HardCut
{
    partial class ToolboxCustomTrackBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maxPanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.valuePanel = new System.Windows.Forms.Panel();
            this.backdropPanel = new System.Windows.Forms.Panel();
            this.minLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.backdropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // maxPanel
            // 
            this.maxPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxPanel.Location = new System.Drawing.Point(356, 33);
            this.maxPanel.Name = "maxPanel";
            this.maxPanel.Size = new System.Drawing.Size(10, 112);
            this.maxPanel.TabIndex = 0;
            // 
            // minPanel
            // 
            this.minPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minPanel.Location = new System.Drawing.Point(248, 30);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(10, 112);
            this.minPanel.TabIndex = 0;
            this.minPanel.MouseEnter += new System.EventHandler(this.minPanel_MouseEnter);
            this.minPanel.MouseLeave += new System.EventHandler(this.minPanel_MouseLeave);
            this.minPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.minPanel_MouseMove);
            // 
            // valuePanel
            // 
            this.valuePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.valuePanel.Location = new System.Drawing.Point(306, 30);
            this.valuePanel.Name = "valuePanel";
            this.valuePanel.Size = new System.Drawing.Size(10, 112);
            this.valuePanel.TabIndex = 0;
            // 
            // backdropPanel
            // 
            this.backdropPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backdropPanel.Controls.Add(this.maxPanel);
            this.backdropPanel.Controls.Add(this.minPanel);
            this.backdropPanel.Controls.Add(this.valuePanel);
            this.backdropPanel.Location = new System.Drawing.Point(37, 89);
            this.backdropPanel.Name = "backdropPanel";
            this.backdropPanel.Size = new System.Drawing.Size(543, 175);
            this.backdropPanel.TabIndex = 0;
            this.backdropPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backdropPanel_Paint);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(3, 11);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(35, 13);
            this.minLabel.TabIndex = 1;
            this.minLabel.Text = "label1";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(122, 11);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(35, 13);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "label2";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(210, 11);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(35, 13);
            this.maxLabel.TabIndex = 3;
            this.maxLabel.Text = "label3";
            // 
            // ToolboxCustomTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.backdropPanel);
            this.Name = "ToolboxCustomTrackBar";
            this.Size = new System.Drawing.Size(630, 279);
            this.Load += new System.EventHandler(this.ToolboxCustomTrackBar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ToolboxCustomTrackBar_Paint);
            this.backdropPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel backdropPanel;
        private System.Windows.Forms.Panel maxPanel;
        private System.Windows.Forms.Panel minPanel;
        private System.Windows.Forms.Panel valuePanel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label maxLabel;
    }
}
