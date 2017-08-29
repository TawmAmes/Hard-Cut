using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class UserControlSlider : UserControl
    {
        
        private void UserControlSlider_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Minimum value of the slider.
        /// </summary>
        [Description("Minimum value of the slider.")]
        public int Min
        {
            get { return min; }
            set { min = value; } // Invalidate();
        }
        int min = 0;

        /// <summary>
        /// Maximum value of the slider.
        /// </summary>
        [Description("Maximum value of the slider.")]
        public int Max
        {
            get { return max; }
            set { max = value; Invalidate(); }
        }
        int max = 100;

        /// <summary>
        /// Minimum value of the selection range.
        /// </summary>
        [Description("Minimum value of the selection range.")]
        public int SelectedMin
        {
            get { return selectedMin; }
            set
            {
                selectedMin = value;
                if (SelectionChanged != null)
                    SelectionChanged(this, null);
                Invalidate();
            }
        }
        int selectedMin = 0;

        /// <summary>
        /// Maximum value of the selection range.
        /// </summary>
        [Description("Maximum value of the selection range.")]
        public int SelectedMax
        {
            get { return selectedMax; }
            set
            {
                selectedMax = value;
                if (SelectionChanged != null)
                    SelectionChanged(this, null);
                Invalidate();
            }
        }
        int selectedMax = 100;

        /// <summary>
        /// Current value.
        /// </summary>
        [Description("Current value.")]
        public int Value
        {
            get { return value; }
            set
            {
                this.value = value;
                if (ValueChanged != null)
                    ValueChanged(this, null);
                Invalidate();
            }
        }
        int value = 50;

        /// <summary>
        /// Fired when SelectedMin or SelectedMax changes.
        /// </summary>
        [Description("Fired when SelectedMin or SelectedMax changes.")]
        public event EventHandler SelectionChanged;

        /// <summary>
        /// Fired when Value changes.
        /// </summary>
        [Description("Fired when Value changes.")]
        public event EventHandler ValueChanged;

        public UserControlSlider()
        {
            InitializeComponent();
            //avoid flickering
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Paint += new PaintEventHandler(UserControlSlider_Paint);
            MouseDown += new MouseEventHandler(UserControlSlider_MouseDown);
            MouseMove += new MouseEventHandler(UserControlSlider_MouseMove);
        }

        void UserControlSlider_Paint(object sender, PaintEventArgs e)
        {
            //paint background in white
            //e.Graphics.FillRectangle(Brushes.White, ClientRectangle);
            //e.Graphics.FillEllipse(Brushes.Green, ClientRectangle);
            
            //paint selection range in blue
            Rectangle selectionRect = new Rectangle(
                (SelectedMin - Min) * Width / (Max - Min),
                15,
                (SelectedMax - selectedMin) * Width / (Max - Min),
                Height-30);

            e.Graphics.FillRectangle(Brushes.White, selectionRect);

            //Console.WriteLine(string.Format("( {0} - {1} ) * {2} / ( {3} - {4} ) = {5}", 
            //   selectedMin, Min, Width, Max, Min, (selectedMin - Min) * Width / (Max - Min)));

            var triangleSize = 3;

            //First Frame Slider Thumb
            Point[] leftTriangle = new Point[] {
                new Point((SelectedMin - Min) * Width / (Max - Min), Height/2),
                new Point((SelectedMin - Min) * Width / (Max - Min) - 5, Height/2 + 5),
                new Point((SelectedMin - Min) * Width / (Max - Min) - 5, Height/2 - 5)
            };
            e.Graphics.FillPolygon(Brushes.DarkBlue, leftTriangle);

            /*
            Rectangle firstFrameRect = new Rectangle(
                SelectedMin * Width / (Max - Min),
                0,
                5 * Width / (Max - Min),
                Height
                );
            e.Graphics.FillRectangle(Brushes.DarkBlue, firstFrameRect);
            */

            var wid = (SelectedMax - selectedMin) * Width / (Max - Min);
            //Last Frame Slider Thumb
            Point[] rightTriangle = new Point[] {
                new Point((SelectedMax - Min) * Width / (Max - Min), Height/2),
                new Point((SelectedMax - Min) * Width / (Max - Min) + 5, Height/2 + 5),
                new Point((SelectedMax - Min) * Width / (Max - Min) + 5, Height/2 - 5)
                //new Point(SelectedMax + 5, Height/2 + 5),
                //new Point(SelectedMax + 5, Height/2 - 5)
            };
            //e.Graphics.DrawPolygon(Pens.Red, rightTriangle);
            e.Graphics.FillPolygon(Brushes.DarkBlue, rightTriangle);

            /*
            Point[] rightTriangle = new Point[] { new Point(0, 15), new Point(10, 15), new Point(5, 10) };

            Rectangle lastFrameRect = new Rectangle(
                SelectedMax * Width / (Max - Min),
                0,
                5 * Width / (Max - Min),
                Height
                );

            e.Graphics.FillRectangle(Brushes.DarkBlue, lastFrameRect);
            */

            //Console.Out.Write(selectionRect.IntersectsWith(ClientRectangle));

            //e.Graphics.FillRectangle(Brushes.Blue, selectionRect);

            //draw a black frame around our control
            //e.Graphics.DrawRectangle(Pens.Black, 0, Height/4, Width - 1, (Height/2) - 1);

            //draw a simple vertical line at the Value position
            e.Graphics.DrawLine(Pens.Black,
                (Value - Min) * Width / (Max - Min) - 5, 0,
                (Value - Min) * Width / (Max - Min) - 5, Height/2);
        }

        void UserControlSlider_MouseDown(object sender, MouseEventArgs e)
        {
            //check where the user clicked so we can decide which thumb to move
            int pointedValue = Min + e.X * (Max - Min) / Width;
            int distValue = Math.Abs(pointedValue - Value);
            int distMin = Math.Abs(pointedValue - SelectedMin);
            int distMax = Math.Abs(pointedValue - SelectedMax);
            int minDist = Math.Min(distValue, Math.Min(distMin, distMax));
            if (minDist == distValue)
                movingMode = MovingMode.MovingValue; //this should only move when video plays
            else if (minDist == distMin)
                movingMode = MovingMode.MovingMin;
            else
                movingMode = MovingMode.MovingMax;
            //call this to refreh the position of the selected thumb
            UserControlSlider_MouseMove(sender, e);
        }

        void UserControlSlider_MouseMove(object sender, MouseEventArgs e)
        {
            //if the left button is pushed, move the selected thumb
            if (e.Button != MouseButtons.Left)
                return;
            int pointedValue = Min + e.X * (Max - Min) / Width;
            if (movingMode == MovingMode.MovingValue)
            {
                if (pointedValue <= Max && pointedValue >= Min)
                    Value = pointedValue;
            }
            else if (movingMode == MovingMode.MovingMin)
            {
                if (pointedValue < SelectedMax && pointedValue >= Min)
                    SelectedMin = pointedValue;
            }
            else if (movingMode == MovingMode.MovingMax)
            {
                if (pointedValue > SelectedMin && pointedValue <= Max)
                    SelectedMax = pointedValue;
            }
        }

        /// <summary>
        /// To know which thumb is moving
        /// </summary>
        enum MovingMode { MovingValue, MovingMin, MovingMax }
        MovingMode movingMode;
    }
}
