using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosedDemo.After
{
    public class Square : IShape
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
        public void Draw()
        {
            var topLeft = new Tuple<decimal, decimal>(this.Top, this.Left);
            var side = this.Side;
            Console.WriteLine("Square: TopLeft={0}; side={1}", 
                topLeft, side);
        }
    }
}
