/*
 * Do I figure out Min and Max from 0 to 100 or based on backdropPanel?
 * I prefer Min and Max. How do I do that?
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardCut
{
    public partial class ToolboxCustomTrackBar : UserControl
    {

        List<Panel> panels = new List<Panel>();
        List<Label> labels = new List<Label>();
        float panelBrightnessFactor = 1.5f;

        #region variables
        private int min = 0;
        private int max = 1000; //total frames in video
        private int selectedMin = 0;
        private int selectedMax = 1000;
        private int selectedValue = 400;
        private int selectionWidth = 0;
        private int labelHeight = 200;
        private int panelWidth = 10;
        #endregion

        #region accessors
        public int Min
        {
            get { return min; }
            set { min = value; Invalidate(); }
        }
        public int Max
        {
            get { return max; }
            set { max = value; Invalidate(); }
        }
        public int SelectedMin
        {
            get { return selectedMin; }
            set
            {
                selectedMin = value;
                Invalidate();
            }
        }
        public int SelectedMax
        {
            get { return selectedMax; }
            set
            {
                selectedMax = value;
                Invalidate();
            }
        }
        public int SelectedValue
        {
            get { return selectedValue; }
            set { selectedValue = value; Invalidate(); }
        }
        public int LabelHeight
        {
            get { return labelHeight; }
            set { labelHeight = value; Invalidate(); }
        }
        public int PanelWidth
        {
            get { return panelWidth; }
            set { panelWidth = value; Invalidate(); }
        }
        #endregion

        public ToolboxCustomTrackBar()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            panels.Add(minPanel);
            panels.Add(maxPanel);
            panels.Add(valuePanel);
            panels.Add(backdropPanel);

            labels.Add(minLabel);
            labels.Add(valueLabel);
            labels.Add(maxLabel);

            SelectedMax = Max;
            SelectedValue = (Max - Min) / 2;
            selectionWidth = Max - Min;

            //Setting backcolor here instead of in Paint() method due to the Light() and Dark() methods when mouse enters panel
            backdropPanel.BackColor = Color.LightBlue;
            minPanel.BackColor = Color.DarkRed;
            maxPanel.BackColor = Color.DarkGreen;
            valuePanel.BackColor = Color.Black;

            foreach (var panel in panels)
            {
                Controls.Add(panel);
            }
            foreach (var label in labels)
            {
                Controls.Add(label);
                label.Height = LabelHeight;
            }

            //TODO: figure out how the user will create multiple areas to Hard Cut

        }

        private void ToolboxCustomTrackBar_Paint(object sender, PaintEventArgs e)
        {
            //when i allow for scrolling into the TrackBar / Timeline, i'll want to repaint all the time
            backdropPanel.Location = new Point(Min, LabelHeight);
            backdropPanel.Width = Width;
            backdropPanel.Height = Height - LabelHeight;

            foreach (var panel in panels)
            {
                if (panel != backdropPanel)
                {
                    panel.Height = Height - LabelHeight;
                    panel.Width = PanelWidth;
                }
            }

            minPanel.Location = new Point(SelectedMin - (PanelWidth / 2), backdropPanel.Location.Y);

            maxPanel.Location = new Point((SelectedMax * Width / (Max - Min)) - 1, backdropPanel.Location.Y);
            valuePanel.Location = new Point((SelectedValue) * Width / (Max - Min), backdropPanel.Location.Y);

            minLabel.Location = new Point(minPanel.Location.X - (minLabel.Width / 2) + (minPanel.Width / 2), minPanel.Location.Y - LabelHeight);
            minLabel.Text = SelectedMin.ToString();

            maxLabel.Location = new Point(SelectedMax - (maxLabel.Width / 2) + (maxPanel.Width / 2), backdropPanel.Location.Y - LabelHeight);
            maxLabel.Text = SelectedMax.ToString();

            valueLabel.Location = new Point(SelectedValue - (valueLabel.Width / 2) + (valuePanel.Width / 2), backdropPanel.Location.Y - LabelHeight);
            valueLabel.Text = SelectedValue.ToString();
        }

        private void backdropPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ToolboxCustomTrackBar_Load(object sender, EventArgs e)
        {

        }

        //this will be redundant...
        #region MinPanel actions
        private Point _Offset = Point.Empty;
        private void minPanel_MouseEnter(object sender, EventArgs e)
        {
            minPanel.BackColor = ControlPaint.Light(minPanel.BackColor, panelBrightnessFactor);
        }
        private void minPanel_MouseLeave(object sender, EventArgs e)
        {
            minPanel.BackColor = ControlPaint.Dark(minPanel.BackColor, panelBrightnessFactor * 4.0f);
        }

        private void minPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return; //ensure user left-clicked

            SelectedMin += Min + e.X * (Max - Min) / Width;
        }


        #endregion

        
    }
}
