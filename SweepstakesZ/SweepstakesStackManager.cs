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

            Console.WriteLine("Elements in stack: ");
            foreach (Sweepstakes sweep in sweepStack)
            {
                Console.WriteLine(sweep.name);
            }
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepToReturn = sweepStack.Pop();
            return sweepToReturn;
        }

    }       
}
