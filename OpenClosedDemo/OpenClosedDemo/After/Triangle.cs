using System;

namespace OpenClosedDemo.After
{
    public class Triangle : IShape
    {
        public decimal Side1 { get; set; }
        public decimal Side2 { get; set; }
        public decimal Side3 { get; set; }

        public void Draw()
        {
            Console.WriteLine("Triangle: Sides={0}, {1}, {3}", 
                Side1, Side2, Side3);
        }
    }
}
