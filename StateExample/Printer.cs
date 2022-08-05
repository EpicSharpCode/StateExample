using StateExample.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample
{
    internal class Printer
    {
        public IdleState idleState { get; private set; }
        public PrintState printState { get; private set; }
        public RefillState refillState { get; private set; }
        public MaintenanceState maintenanceState { get; private set; }

        public IState currentState { get; private set; }
        public int resources { get; private set; }

        public Printer()
        {
            idleState = new IdleState(this);
            printState = new PrintState(this);
            refillState = new RefillState(this);
            maintenanceState = new MaintenanceState(this);

            currentState = idleState;
            resources = 0;
        }

        public void SetCurrentState(IState state) => currentState = state;

        public void AddResources(int count = 1) 
        { 
            if (count < 0) { return; } 
            resources += count; 
        }
        public void ReduceResources(int count = 1)
        {
            if (count < 0) { return; }
            resources -= count;
        }

        public void Refill() => currentState.Refill();
        public void Print() => currentState.Print();
        public void Maintenance() => currentState.Maintenance();
        public void Idle() => currentState.Idle();
        public void Action() => currentState.Action();

    }
}
