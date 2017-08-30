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
            this.backdropPanel = new System.Windows.Forms.Panel();
            this.maxPanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.valuePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // backdropPanel
            // 
            this.backdropPanel.Location = new System.Drawing.Point(3, 3);
            this.backdropPanel.Name = "backdropPanel";
            this.backdropPanel.Size = new System.Drawing.Size(416, 93);
            this.backdropPanel.TabIndex = 0;
            this.backdropPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backdropPanel_Paint);
            // 
            // maxPanel
            // 
            this.maxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.maxPanel.Location = new System.Drawing.Point(309, 179);
            this.maxPanel.Name = "maxPanel";
            this.maxPanel.Size = new System.Drawing.Size(47, 93);
            this.maxPanel.TabIndex = 1;
            // 
            // minPanel
            // 
            this.minPanel.Location = new System.Drawing.Point(120, 179);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(56, 93);
            this.minPanel.TabIndex = 1;
            this.minPanel.MouseEnter += new System.EventHandler(this.minPanel_MouseEnter);
            this.minPanel.MouseLeave += new System.EventHandler(this.minPanel_MouseLeave);
            // 
            // valuePanel
            // 
            this.valuePanel.Location = new System.Drawing.Point(211, 179);
            this.valuePanel.Name = "valuePanel";
            this.valuePanel.Size = new System.Drawing.Size(47, 93);
            this.valuePanel.TabIndex = 1;
            // 
            // ToolboxCustomTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maxPanel);
            this.Controls.Add(this.backdropPanel);
            this.Controls.Add(this.valuePanel);
            this.Controls.Add(this.minPanel);
            this.Name = "ToolboxCustomTrackBar";
            this.Size = new System.Drawing.Size(547, 369);
            this.Load += new System.EventHandler(this.ToolboxCustomTrackBar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ToolboxCustomTrackBar_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backdropPanel;
        private System.Windows.Forms.Panel maxPanel;
        private System.Windows.Forms.Panel minPanel;
        private System.Windows.Forms.Panel valuePanel;
    }
}
