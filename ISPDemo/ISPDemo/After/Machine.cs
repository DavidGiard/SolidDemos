using ISPDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo.After
{
    public class Machine: IPrinter, IFax, IPhotocopier, IScanner, IStapler
    {
        public void Print(List<Document> documents)
        {
            // Print the items.
            foreach (var doc in documents)
            {
                Console.WriteLine("Printing {0}...", doc.Text);
            }
            Console.WriteLine("All Items printed" + documents.Count());
        }

        public void Staple(List<Document> documents)
        {
            // Staple the items.
            foreach (var doc in documents)
            {
                Console.WriteLine("Stapling {0}...", doc.Text);
            }
            Console.WriteLine("Items stapled" + documents.Count());
        }

        public void Fax(List<Document> documents)
        {
            // Fax the items.
            foreach (var doc in documents)
            {
                Console.WriteLine("Faxing {0}...", doc.Text);
            }
            Console.WriteLine("All Items Faxed" + documents.Count());
        }

        public void Scan(List<Document> documents)
        {
            // Scan the items.
            foreach (var doc in documents)
            {
                Console.WriteLine("Scanning {0}...", doc.Text);
            }
            Console.WriteLine("All Items Scanned" + documents.Count());
        }

        public void PhotoCopy(List<Document> documents)
        {
            // Xerox the items.
            foreach (var doc in documents)
            {
                Console.WriteLine("Copying {0}...", doc.Text);
            }
            Console.WriteLine("All Items Photo copied" + documents.Count());
        }
    }
}
