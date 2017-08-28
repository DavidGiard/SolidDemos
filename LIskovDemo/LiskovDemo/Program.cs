using System;

namespace LiskovDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEFORE");
            B_CalculateRectangleArea();
            B_CalculateSquareArea();
            B_CalculateThisArea();
            Console.WriteLine();

            Console.WriteLine("AFTER");
            A_CalculateRectangleArea();
            A_CalculateSquareArea();
            A_CalculateThisArea();


            Console.ReadLine();
        }

        private static void B_CalculateSquareArea()
        {
            var s = 10;
            var r = new Before.Square()
                { Width = s};
            var area = r.Area();
            Console.WriteLine("Square ({0} x {0}) has area {1}", s, area);
            Console.WriteLine();
        }

        private static void B_CalculateRectangleArea()
        {
            var w = 10;
            var h = 5;
            var r = new Before.Rectangle()
                { Width = w, Height=h };
            var area = r.Area();
            Console.WriteLine("Rectangle ({0} x {1}) has area {2}", w, h, area);
            Console.WriteLine();
        }

        private static void B_CalculateThisArea()
        {
            var w = 10;
            var h = 5;
            // Substitue Child instance!!!
            Before.Rectangle r = new Before.Square()
                { Height = h, Width = w };
            var area = r.Area();
            Console.WriteLine("Rectangle ({0} x {1}) has area {2}", w, h, area);
            Console.WriteLine();
        }

        private static void A_CalculateSquareArea()
        {
            var s = 10;
            var r = new After.Square()
            { Side = s };
            var area = r.Area();
            Console.WriteLine("Square ({0} x {0}) has area {1}", s, area);
            Console.WriteLine();
        }

        private static void A_CalculateRectangleArea()
        {
            var w = 10;
            var h = 5;
            var r = new After.Rectangle()
            { Width = w, Height = h };
            var area = r.Area();
            Console.WriteLine("Rectangle ({0} x {1}) has area {2}", w, h, area);
            Console.WriteLine();
        }

        private static void A_CalculateThisArea()
        {
            var s = 10;
            // Substitue Child instance!!!
            After.IShape shape = new After.Square()
            { Side = s };
            var area = shape.Area();
            Console.WriteLine("Shape ({0} x {0}) has area {1}", s, area);
            Console.WriteLine();
        }

    }
}
