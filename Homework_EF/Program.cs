using System;
using Homework_EF.Servises;

namespace Homework_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var reporter = new Reporter();
            reporter.MakeReport();
            Console.ReadLine();
        }
    }
}
