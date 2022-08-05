using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample.State
{
    internal class RefillState : IState
    {
        Printer printer;

        public RefillState(Printer _printer)
        {
            printer = _printer;
        }

        public void Action()
        {
            printer.AddResources();
            Console.WriteLine("[] Printer is Refilled...");

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
            Console.WriteLine("Printer need to be in Idle State");
        }

        public void Refill()
        {
            Console.WriteLine("Already in Refill State");
        }
    }
}
