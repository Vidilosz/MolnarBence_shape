using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Square : Rectangle
    {
        public Square(string color, double side, bool isHoley = false)
            : base(color, side, side, isHoley) { }

        public override string ToString() => "Négyzet. " + base.ToString();
    }
}
