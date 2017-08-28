using System;
using System.Collections.Generic;
using System.Linq;
using ISPDemo.Models;

namespace ISPDemo.After
{
    public class Printer : IPrinter
    {
        public void Print(List<Document> documents)
        {
            foreach (var doc in documents)
            {
                Console.WriteLine("Printing {0}...", doc.Text);
            }
            Console.WriteLine("All Items printed" + documents.Count());
        }
    }
}
