using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CircleR : Shape
    {
        public double Radius { get; set; }

        public CircleR(string color, double radius, bool isHoley = false)
            : base(color, isHoley)
        {
            Radius = radius;
        }

        public override double Perimeter2() => 2 * Math.PI * Radius;
        public override double Area3() => Math.PI * Radius * Radius;

        public override string ToString() => base.ToString() + " (Kör)";
    }
}
