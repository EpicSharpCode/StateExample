using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample.State
{
    internal interface IState
    {
        void Idle();
        void Print();
        void Refill();
        void Maintenance();

        void Action();
    }
}
