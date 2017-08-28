using System;
using System.Collections.Generic;
using ISPDemo.Models;

namespace ISPDemo.After
{
    public class FaxMachine : IFax
    {
        public void Fax(List<Document> documents)
        {
            // Fax the items.
            foreach (var doc in documents)
            {
                Console.WriteLine("Faxing {0}...", doc.Text);
            }
            Console.WriteLine("All Items Faxed" + documents.Count);
        }

    }
}
