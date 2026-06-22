using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    internal class Circle: Shape
    {
        public double Radius { get; set; }
        public Circle
            (
                double radius,
                int StartX, int StartY, int lineWidth, System.Drawing.Color Color
            ) : base(StartX, StartY, lineWidth, Color)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override void Draw(System.Windows.Forms.PaintEventArgs e)
        {
            Console.WriteLine("Нужно нарисовать круг");
            System.Drawing.Pen pen = new System.Drawing.Pen(Color, LineWidth);
            e.Graphics.DrawEllipse(pen, StartX, StartY, (float)Radius * 2, (float)Radius * 2);
        }
        public override void Info(System.Windows.Forms.PaintEventArgs e)
        {
            Console.WriteLine($"Радиус круга: {Radius}");
            base.Info(e);
        }
    }
}
