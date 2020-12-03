using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepStack = new Stack<Sweepstakes>();

        //Addes a passed in sweepstakes to the top of the stack
        public void InsertSweepstakes(Sweepstakes sweepstake)
        {
            sweepStack.Push(sweepstake);

 
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepToReturn = sweepStack.Pop();
            return sweepToReturn;
        }

    }       
}
