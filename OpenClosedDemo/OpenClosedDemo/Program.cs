using System;
using Before = OpenClosedDemo.Before;
using After = OpenClosedDemo.After;

namespace OpenClosedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before");
            object[] beforeShapes = new object[] 
                {
                    new Before.Circle(5, 10, 10),
                    new Before.Square(8, 20, 20)
                };
            var b_Drawing = new Before.DrawingService();
            b_Drawing.DrawAllShapes(beforeShapes);

            Console.WriteLine();

            Console.WriteLine("After");
            After.IShape[] afterShapes = {
                    new After.Circle(5, 10, 10),
                    new After.Square(8, 20, 20)
                };
            var a_Drawing = new After.DrawingService();
            a_Drawing.DrawAllShapes(afterShapes);
            Console.ReadLine();

        }
    }
}
