using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample.State
{
    internal class MaintenanceState : IState
    {
        Printer printer;

        public MaintenanceState(Printer _printer)
        {
            printer = _printer;
        }

        public void Action() { }

        public void Idle()
        {
            Console.WriteLine("-> Enter in Idle State");
            printer.SetCurrentState(printer.idleState);
        }

        public void Maintenance()
        {
            Console.WriteLine("Already in Maintenance State");
        }

        public void Print()
        {
            Console.WriteLine("Printer need to be in Idle State");
        }

        public void Refill()
        {
            Console.WriteLine("-> Enter in Refill State");
            printer.SetCurrentState(printer.refillState);
        }
    }
}

