using DependencyInversionDemo.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Before = DependencyInversionDemo.Before;
//using After = DependencyInversionDemo.After;

namespace DependencyInversionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                await MainAsync();
                //await Before_Emotions();
            }).GetAwaiter().GetResult();
            Console.WriteLine("Done");

            Console.ReadLine();
        }

        static async Task MainAsync()
        {
            Console.WriteLine("BEFORE");
            var b_ec = new Before.EmotionCaller();
            string b_Results = await b_ec.GetEmotions();
            Console.WriteLine(b_Results);
            Console.WriteLine();

            Console.WriteLine("AFTER");
            IEmotionLib el = new After.OnlineEmotionLib();
            var a_ec = new After.EmotionCaller(el);
            string a_Results = await a_ec.GetEmotions();
            Console.WriteLine(a_Results);

        }
    }
}
