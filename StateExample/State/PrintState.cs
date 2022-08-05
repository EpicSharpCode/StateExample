using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample.State
{
    internal class PrintState : IState
    {
        Printer printer;

        public PrintState(Printer _printer)
        {
            printer = _printer;
        }

        public void Action()
        {
            if (printer.resources > 0)
            {
                printer.ReduceResources();
                Console.WriteLine("[] Printing some media files...");
            } else
            {
                Console.WriteLine("Printer dont have resources");
            }
        }

        public void Idle()
        {
            Console.WriteLine("-> Enter in Idle State");
            printer.SetCurrentState(printer.idleState);
        }

        public void Maintenance()
        {
            Console.WriteLine("-> Enter in Maintenance State");
            printer.SetCurrentState(printer.maintenanceState);
        }

        public void Print()
        {
            Console.WriteLine("Already in Print State");
        }

        public void Refill()
        {
            Console.WriteLine("Printer need to be in Maintenance State");
        }
    }
}
