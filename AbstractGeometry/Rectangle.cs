using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Rectangle: Shape, IHaveDiagonal
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle
            (
                double width, double height,
                int StartX, int StartY, int lineWidth, Color Color
            ) : base(StartX, StartY, lineWidth, Color)
        {
            Width = width;
            Height = height;
        }
        public double GetDiagonal()
        {
            return Math.Sqrt(Width*Width + Height * Height);
        }
        public void DrawDiagonal(PaintEventArgs e)
        {
            Pen pen =new Pen(Color,1);
            e.Graphics.DrawLine(pen, StartX, StartY, StartX+(float)Width, StartY+(float)Height);
            base.Info(e);
        }
        public override double GetArea()
        {
            return Width * Height;
        }
        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height); 
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Ширина прямоугольника: {Width}");
            Console.WriteLine($"Высота прямоугольника: {Height}");
            Console.WriteLine($"Диагональ прямоугольника: {GetDiagonal()}");
            DrawDiagonal(e);
            base.Info(e);
        }
    }
}
