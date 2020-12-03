using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //Member Variables
        Stack<Sweepstakes> sweepStack = new Stack<Sweepstakes>();

        //Constructor
        public SweepstakesStackManager()
        {

        }
        
        //Member Methods
        //Addes a passed in sweepstakes to the top of the stack
        public void InsertSweepstakes(Sweepstakes sweepstake)
        {
            sweepStack.Push(sweepstake);
        }

        //Removes the last Sweepstakes added in the stack and rerurns it
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepToReturn = sweepStack.Pop();
            return sweepToReturn;
        }

    }       
}
