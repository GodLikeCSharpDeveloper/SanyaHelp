using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ConsoleApplication
    {
        //private readonly IShape _shapeService;
        //public ConsoleApplication(IShape shape)
        //{
        //    _shapeService = shape;
        //}

        // Application starting point
        public void Run()
        {
            IShape square = new Square();
            var squareArea = square.Area(2);
            IShape circle = new Circle();
            var circleArea = circle.Area(2);
            Console.WriteLine(circleArea.ToString());
            Console.WriteLine(squareArea.ToString());
        }
    }
}
