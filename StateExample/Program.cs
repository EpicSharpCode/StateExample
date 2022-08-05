using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Refill();
            Console.WriteLine();

            printer.Print();
            printer.Action();
            Console.WriteLine();

            printer.Maintenance();
            Console.WriteLine();

            printer.Refill();
            printer.Action();
            Console.WriteLine();

            printer.Idle();
            Console.WriteLine();

            printer.Print();
            printer.Action();
            Console.WriteLine();

            printer.Print();
            printer.Action();
            Console.WriteLine();

            printer.Maintenance();
            Console.WriteLine();

            printer.Print();
            printer.Action();
            Console.WriteLine();

            printer.Refill();
            printer.Action();
            Console.WriteLine();

            printer.Refill();
            Console.WriteLine();

            printer.Idle();

            Console.ReadLine();
        }
    }
}
