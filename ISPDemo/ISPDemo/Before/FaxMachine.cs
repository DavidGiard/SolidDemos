using ISPDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ISPDemo.Before
{
    class FaxMachine : IMachine
    {
        public void Fax(List<Document> documents)
        {
            foreach (var doc in documents)
            {
                Console.WriteLine("Faxing {0}...", doc.Text);
            }
            Console.WriteLine("All Items Faxed" + documents.Count());
        }

        public void PhotoCopy(List<Document> documents)
        {
            throw new NotImplementedException();
        }

        public void Print(List<Document> documents)
        {
            throw new NotImplementedException();
        }

        public void Scan(List<Document> documents)
        {
            throw new NotImplementedException();
        }

        public void Staple(List<Document> documents)
        {
            throw new NotImplementedException();
        }
    }
}
