using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosedDemo.Before
{
    public class Square
    {
        public decimal Side { get; set; }
        public decimal Top { get; set; }
        public decimal Left { get; set; }

        public Square(decimal side, decimal top, decimal left)
        {
            Side = side;
            Top = top;
            Left = left;
        }
    }
}
