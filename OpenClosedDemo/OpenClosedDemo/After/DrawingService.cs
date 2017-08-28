using System;

namespace OpenClosedDemo.After
{
    public class DrawingService
    {
        public void DrawAllShapes(IShape[] shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

        public void DrawCircle(Circle circle)
        {
            var center = new Tuple<decimal, decimal>(circle.CenterX, circle.CenterY);
            var radius = circle.Radius;
        }

        public void DrawSquare(Square square)
        {
            var topLeft = new Tuple<decimal, decimal>(square.Top, square.Left);
            var side = square.Side;

        }
    }
}
