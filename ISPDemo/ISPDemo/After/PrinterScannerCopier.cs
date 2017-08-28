using System;
using System.Collections.Generic;
using ISPDemo.Models;

namespace ISPDemo.After
{
    public class PrinterScannerCopier : IPrinter, IScanner, IPhotocopier
    {
        public void PhotoCopy(List<Document> documents)
        {
            foreach (var doc in documents)
            {
                Console.WriteLine("Photocopying {0}...", doc.Text);
            }
            Console.WriteLine("All Items Photocopied" + documents.Count);
        }

        public void Print(List<Document> documents)
        {
            foreach (var doc in documents)
            {
                Console.WriteLine("Printing {0}...", doc.Text);
            }
            Console.WriteLine("All Items Printed" + documents.Count);
        }

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
