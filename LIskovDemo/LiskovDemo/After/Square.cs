using System;

namespace LiskovDemo.After
{
    public class Square : IShape
    {
        public int Side { get; set; }

        public int Area()
        {
            return Side * Side;
        }
    }
}
