using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Circle :IShape
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public const double Pi = 3.14;
        public double Area(double width, double length)
        {
            return 0;
        }

        public double Area(double width)
        {
            return width * width * Pi;
        }
    }
}
