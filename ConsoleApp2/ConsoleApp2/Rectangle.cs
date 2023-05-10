using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Rectangle : IShape
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area(double width, double length)
        {
            var area = width * length;
            return area;
        }
        public double Area(double width)
        {
            return 0;
        }
    }
}
