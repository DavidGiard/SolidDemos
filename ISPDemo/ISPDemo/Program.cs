using System;
using Before = ISPDemo.Before;
using After = ISPDemo.After;
using ISPDemo.Models;
using System.Collections.Generic;

namespace ISPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var documents = new List<Document>();
            documents.Add(new Document("Doc1"));
            documents.Add(new Document("Doc2"));
            documents.Add(new Document("Doc3"));

            // Before
            Console.WriteLine("BEFORE");
            Console.WriteLine("Machine:");
            var b_machine = new Before.Machine();
            b_machine.Print(documents);
            Console.WriteLine();

            //Console.WriteLine("Printer:");
            //var b_Printer = new Before.Machine();
            //b_Printer.Print(documents);
            //Console.WriteLine();


            // After
            Console.WriteLine("AFTER");
            Console.WriteLine("Machine:");
            var a_machine = new After.Machine();
            a_machine.Print(documents);
            Console.WriteLine();

            Console.WriteLine("Scanner:");
            var a_Scanner = new After.Scanner();
            a_Scanner.Scan(documents);

            Console.ReadLine();
        }
    }
}
