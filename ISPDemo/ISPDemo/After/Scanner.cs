using System;
using System.Collections.Generic;
using ISPDemo.Models;

namespace ISPDemo.After
{
    public class Scanner : IScanner
    {
        public void Scan(List<Document> documents)
        {
            foreach (var doc in documents)
            {
                Console.WriteLine("Scanning {0}...", doc.Text);
            }
            Console.WriteLine("All Items Scanned" + documents.Count);
        }
    }
}
