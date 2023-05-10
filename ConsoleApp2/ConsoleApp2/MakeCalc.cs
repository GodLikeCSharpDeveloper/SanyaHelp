using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MakeCalc
    {
        private readonly IShape shape;
        public MakeCalc(IShape shape)
        {
            this.shape = shape;
        }

    }
}
