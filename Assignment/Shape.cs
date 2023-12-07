using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Shape
    {
        internal virtual float CalculateArea()
        {
            return 0;
        }
    }

    internal class Circle : Shape
    {
        internal float Radius { get; set; }

        internal override float CalculateArea()
        {
            return (float)(Math.PI * Math.Pow(Radius, 2));
        }
    }

}
