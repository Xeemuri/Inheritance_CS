using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal abstract class Shape
    {
        protected int StartX { get; set; }
        protected int StartY { get; set; }
        protected int LineWidth { get; set; }
        protected Color Color { get; set; }
        
        public Shape(int StartX, int StartY, int lineWidth, Color Color)
        {
            this.StartX = StartX;
            this.StartY = StartY;
            this.LineWidth = lineWidth;
            this.Color = Color;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Draw(PaintEventArgs e);
        public virtual void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Площадь фигуры: {GetArea()}");
            Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
            Draw(e);
        }
    }
}
