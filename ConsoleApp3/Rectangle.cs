using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(string color, double height, double width, bool isHoley = false)
            : base(color, isHoley)
        {
            Height = height;
            Width = width;
        }

        public override double Perimeter2() => 2 * (Height + Width);
        public override double Area3() => Height * Width;

        public override string ToString() => base.ToString() + " (Téglalap)";
    }
}
