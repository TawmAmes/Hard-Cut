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
    public partial class TriangleSliderUC : UserControl
    {
        //Take a value from the Form for size and color of the triangle.
        //If no value is found, use default values.

        double hypotenuse;
        double finalPoint;

        public double Hypotenuse
        {
            get { return hypotenuse; }
            set
            {
                hypotenuse = value;
                UpdateTriangle();
            }
        }

        public double FinalPoint
        {
            get { return finalPoint; }
            set
            {
                finalPoint = value;
                UpdateTriangle();
            }
        }

        public PointF[] triangle = { new Point(0, 0), new Point(0, 0), new Point(0, 0) };

        public TriangleSliderUC()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);  

            PropertyConstructor();
            UpdateTriangle(); //draw method
        }

        public void PropertyConstructor()
        {
            hypotenuse = 100; //default value
            finalPoint = Math.Sqrt(hypotenuse * hypotenuse - (hypotenuse * 0.5f) * (hypotenuse * 0.5f));
        }

        public void UpdateTriangle()
        {
            triangle[0] = new PointF((int)finalPoint, (int)(hypotenuse * 0.5f));
            triangle[1] = new PointF(0, 0);
            triangle[2] = new PointF(0, (int)hypotenuse);

            Bitmap image = new Bitmap(Width, Height);

            var g = Graphics.FromImage(image);
            g.FillPolygon(Brushes.Orange, triangle);

            this.BackgroundImage = image;
        }

        #region additional methods

        public void ShiftX(float amount)
        {
            for(int i=0; i<triangle.Length; i++)
            {
                triangle[i].X += amount;
            }
            UpdateTriangle();
        }

        public void ShiftY(float amount)
        {
            for (int i = 0; i < triangle.Length; i++)
            {
                triangle[i].Y += amount;
            }
            UpdateTriangle();
        }

        public void FlipX()
        {
            var target = triangle[0];
            ShiftX(target.X);
            target = new PointF(target.X * -1, target.Y);

            UpdateTriangle();
        }

        #endregion
    }
}
