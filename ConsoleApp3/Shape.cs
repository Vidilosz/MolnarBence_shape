using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Shape
    {
        public string Color { get; set; }
        public bool IsHoley { get; private set; }

        public Shape(string color, bool isHoley = false)
        {
            Color = color;
            IsHoley = isHoley;
        }

        public void MakeHoley()
        {
            IsHoley = true;
        }

        public abstract double Perimeter2();
        public abstract double Area3();

        public override string ToString()
        {
            return $"Szín: {Color}, Lyukas: {IsHoley}, Kerület: {Perimeter2()}, Terület: {Area3()}";
        }

        public override bool Equals(object obj)
        {
            return obj is Shape shape && Area3() == shape.Area3();
        }
    }
}
