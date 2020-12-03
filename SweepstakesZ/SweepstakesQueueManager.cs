using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class SweepstakesQueueManager : ISweepstakesManager
    {

        Queue<Sweepstakes> sweepQueue = new Queue<Sweepstakes>();


        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepQueue.Enqueue(sweepstakes);

            Console.WriteLine("Elements in stack: ");
            foreach (Sweepstakes sweep in sweepQueue)
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
