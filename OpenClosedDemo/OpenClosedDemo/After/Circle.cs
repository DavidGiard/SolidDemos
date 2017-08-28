using System;

namespace OpenClosedDemo.After
{
    public class Circle : IShape
    {
        public decimal Radius { get; set; }
        public decimal CenterX { get; set; }
        public decimal CenterY { get; set; }

        public Circle(decimal radius, decimal centerX, decimal centerY)
        {
            Radius = radius;
            CenterX = centerX;
            CenterY = centerY;
        }
        public void Draw()
        {
            var center = new Tuple<decimal, decimal>(this.CenterX, this.CenterY);
            var radius = this.Radius;
            Console.WriteLine("Circle: Center={0}; radius={1}", center, radius);

        }
    }
}
