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

            return null;
        }

    }       
}
