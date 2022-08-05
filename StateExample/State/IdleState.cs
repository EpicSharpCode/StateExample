using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample.State
{
    internal class IdleState : IState
    {
        Printer printer;

        public IdleState(Printer _printer)
        {
            printer = _printer;
        }

        public void Action() { }

        public void Idle()
        {
            Console.WriteLine("Printer already in Idle State");
        }

        public void Maintenance()
        {
            Console.WriteLine("-> Enter in Maintenance State");
            printer.SetCurrentState(printer.maintenanceState);
        }

        public void Print()
        {
            Console.WriteLine("-> Enter in Print State");
            printer.SetCurrentState(printer.printState);
        }

        public void Refill()
        {
            Console.WriteLine("Printer need to be in Maintenance State");
        }
    }
}
