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
    public partial class FloatingValueTrackBar : UserControl
    {

        CustomTrackBar ctb = new CustomTrackBar();



        public FloatingValueTrackBar()
        {
            InitializeComponent();

            ctb.Top = 10;
            ctb.CreateControl();
            ctb.CreateGraphics();

            Label floatingLabel = new Label();

            floatingLabel.SetBounds(ctb.SelectedMin, 0, ctb.Width, Height);
            floatingLabel.Text = ctb.SelectedMin.ToString();

            if(ctb.MinChanged)
            {
                floatingLabel.SetBounds(ctb.SelectedMin, 0, ctb.Width, Height);
                floatingLabel.Text = ctb.SelectedMin.ToString();
            }
        }
    }
}
