using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface IShape
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area(double width, double length);
        public double Area(double width);
    }
}
