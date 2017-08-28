using System;

namespace OpenClosedDemo.Before
{
    public class DrawingService
    {
        public void DrawAllShapes(object[] shapes)
        {
            foreach (var shape in shapes)
            {
                if (shape is Circle)
                {
                    var circle = (Circle)shape;
                    DrawCircle(circle);
                }
                else if (shape is Square)
                {
                    var square = (Square)shape;
                    DrawSquare(square);
                }
            }
        }

        internal void DrawAllShapes(object shapes)
        {
            throw new NotImplementedException();
        }

        public void DrawCircle(Circle circle)
        {
            var center = new Tuple<decimal, decimal>(circle.CenterX, circle.CenterY);
            var radius = circle.Radius;
            Console.WriteLine("Circle: Center={0}; radius={1}", center, radius);
        }

        public void DrawSquare(Square square)
        {
            var topLeft = new Tuple<decimal, decimal>(square.Top, square.Left);
            var side = square.Side;
            Console.WriteLine("Square: TopLeft={0}; side={1}", topLeft, side);

        }
    }
}
