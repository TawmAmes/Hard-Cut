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
        float panelBrightnessFactor = 1.5f;

        public ToolboxCustomTrackBar()
        {
            InitializeComponent();

            //panels = new List<Panel>();
            panels.Add(backdropPanel);
            panels.Add(minPanel);
            panels.Add(maxPanel);
            panels.Add(valuePanel);

            backdropPanel.BackColor = Color.LightBlue;
            minPanel.BackColor = Color.DarkRed;
            maxPanel.BackColor = Color.DarkGreen;
            valuePanel.BackColor = Color.Black;

            foreach(var panel in panels)
            {
                Controls.Add(panel);
            }

            //LocationChanged += (sender, args) => Update();
        }

        private void ToolboxCustomTrackBar_Paint(object sender, PaintEventArgs e)
        {
            Pen tempPen = new Pen(Color.Black, 3);

            foreach(var panel in panels)
            {
                e.Graphics.DrawRectangle(tempPen, panel.Location.X, panel.Location.Y, panel.Width - 1, panel.Height - 1);
            }

            //e.Graphics.DrawRectangle(tempPen, 0, 0, Width, Height);
            //e.Graphics.DrawRectangle(tempPen, backdropPanel.Location.X, backdropPanel.Location.Y, backdropPanel.Width, backdropPanel.Height);
            //e.Graphics.DrawRectangle(tempPen, minPanel.Location.X, minPanel.Location.Y, minPanel.Width, minPanel.Height);
        }

        private void backdropPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minPanel_MouseEnter(object sender, EventArgs e)
        {
            minPanel.BackColor = ControlPaint.Light(minPanel.BackColor, panelBrightnessFactor);
        }
        private void minPanel_MouseLeave(object sender, EventArgs e)
        {
            minPanel.BackColor = ControlPaint.Dark(minPanel.BackColor, panelBrightnessFactor * 4.0f);
        }

        private void ToolboxCustomTrackBar_Load(object sender, EventArgs e)
        {

        }
    }
}
