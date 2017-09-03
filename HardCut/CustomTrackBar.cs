/*
 * Thomas Ames
 * Create a custom TrackBar which will essentially be a rectangle with a StartLine, StopLine, and PlayLine.
 * 
 * StartLine: point in video which the user wants to start the cut from
 * StopLine:  point in video which the user wants to stop  the cut from
 * PlayLine:  point of video which is currently being played
 * 
 * Leaving TrackBar as a rectangle to eventually include audio WaveForm
 * Waveform vid: https://www.youtube.com/watch?v=ZnFoVuOVrUQ
 * 
 * 
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
    public partial class CustomTrackBar : UserControl
    {

        #region variables
        private int min = 0;
        private int max = 1000;
        private int selectedMin = 0;
        private int selectedMax;
        private int value;

        private int sliderWidth = 2;
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
                if (AnythingChanged != null)
                {
                    //SelectionChanged(this, null);
                    AnythingChanged(this, null);
                }
                MinChanged = true;
                Invalidate();
            }
        }
        
        public int SelectedMax
        {
            get { return selectedMax; }
            set
            {
                selectedMax = value;
                if (AnythingChanged != null)
                {
                    //SelectionChanged(this, null);
                    AnythingChanged(this, null);
                }
                MaxChanged = true;
                Invalidate();
                MaxChanged = false;
            }
        }
        
        public int Value
        {
            get { return value; }
            set
            {
                this.value = value;
                if (AnythingChanged != null)
                {
                    //ValueChanged(this, null);
                    AnythingChanged(this, null);
                }
                ValueChanged = true;
                Invalidate();
            }
        }

        public int SliderWidth
        {
            get { return sliderWidth; }
            set
            {
                this.sliderWidth = value;
                Invalidate();
            }
        }

        public Boolean MinChanged
        {
            get; private set;
        }
        public Boolean ValueChanged
        {
            get; private set;
        }
        public Boolean MaxChanged
        {
            get; private set;
        }

        #endregion

        //Fired when SelectedMin or SelectedMax changes.
        //public event EventHandler SelectionChanged;

        //Fired when Value changes.
        //public event EventHandler ValueChanged;

        //Fired if anything changes
        public event EventHandler AnythingChanged;


        public CustomTrackBar()
        {
            //Set default values
            Value = (Max - Min) / 2;
            SelectedMax = Max;

            //SliderWidth = SliderWidth / (Max - Min); //this line is horrible

            InitializeComponent();


            //Avoid flickering
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            //Events
            Paint += new PaintEventHandler(CustomTrackBar_Paint);
            MouseDown += new MouseEventHandler(CustomTrackBar_MouseDown);
            MouseMove += new MouseEventHandler(CustomTrackBar_MouseMove);
        }

        //Create a rectangle
        void CustomTrackBar_Paint(object sender, PaintEventArgs e)
        {
            //paint background in white
            e.Graphics.FillRectangle(Brushes.White, ClientRectangle);

            //Create a rectangle object
            Rectangle selectionRect = new Rectangle(
                0,
                0,
                Width,
                Height);

            /*
            Rectangle selectionRect = new Rectangle(
            (SelectedMin - Min) * Width / (Max - Min),
            15,
            (SelectedMax - selectedMin) * Width / (Max - Min),
            Height - 30);
            */

            //paint the rectangle object
            e.Graphics.FillRectangle(Brushes.GreenYellow, selectionRect);

            //Again how does this work?
            Rectangle firstFrameRect = new Rectangle(
                (SelectedMin - SliderWidth/2) * Width / (Max - Min),
                0,
                SliderWidth * Width / (Max - Min),
                Height
                );
            e.Graphics.FillRectangle(Brushes.DarkBlue, firstFrameRect);


            Rectangle lastFrameRect = new Rectangle(
                (SelectedMax - SliderWidth/2) * Width / (Max - Min),
                0,
                SliderWidth * Width / (Max - Min),
                Height
                );

             /*
                Rectangle lastFrameRect = new Rectangle(
                SelectedMax * Width / (Max - Min),
                0,
                5 * Width / (Max - Min),
                Height
                );
             */

            e.Graphics.FillRectangle(Brushes.OrangeRed, lastFrameRect);


            //draw a black frame around our control
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1);

            //draw a simple vertical line at the Value position
            e.Graphics.DrawLine(Pens.Black,
                (Value - Min) * Width / (Max - Min) - 5,
                0,
                (Value - Min) * Width / (Max - Min) - 5,
                Height);
        }

        void CustomTrackBar_MouseDown(object sender, MouseEventArgs e)
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
            CustomTrackBar_MouseMove(sender, e);
        }

        void CustomTrackBar_MouseMove(object sender, MouseEventArgs e)
        {
            //if the left button is pushed, move the selected thumb
            if (e.Button != MouseButtons.Left)
                return;
            int pointedValue = Min + e.X * (Max - Min) / Width;
            if (movingMode == MovingMode.MovingValue)
            {
                //if (pointedValue <= Max && pointedValue >= Min)
                Value = pointedValue;
            }
            else if (movingMode == MovingMode.MovingMin)
            {
                //if (pointedValue < SelectedMax && pointedValue >= Min)
                SelectedMin = pointedValue;
            }
            else if (movingMode == MovingMode.MovingMax)
            {
                //if (pointedValue > SelectedMin && pointedValue <= Max)
                SelectedMax = pointedValue;
            }
        }


        //To know which thumb is moving
        enum MovingMode { MovingValue, MovingMin, MovingMax }
        MovingMode movingMode;

        public String AllValues()
        {
            return String.Format("{0}\t{1}\t{2}", SelectedMin, Value, SelectedMax);
        }

    }
}
