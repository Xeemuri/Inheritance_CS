using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    internal class Square : Shape
    {
        public double Side { get; set; }
        public Square
            (
                double side,
                int StartX, int StartY, int lineWidth, System.Drawing.Color Color
            ) : base(StartX, StartY, lineWidth, Color)
        {
            Side = side;
        }
        public override double GetArea()
        {
            return Side * Side;
        }
        public override double GetPerimeter()
        {
            return 4 * Side;
        }
        public override void Draw(System.Windows.Forms.PaintEventArgs e)
        {
            Console.WriteLine("Нужно нарисовать квадрат");
            System.Drawing.Pen pen = new System.Drawing.Pen(Color, LineWidth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Side, (float)Side);
        }
        public override void Info(System.Windows.Forms.PaintEventArgs e)
        {
            Console.WriteLine($"Сторона квадрата: {Side}");
            base.Info(e);
        }
    }
}
