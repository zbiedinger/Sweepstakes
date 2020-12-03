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

        //Addes a passed in sweepstakes to the end od the queue
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepQueue.Enqueue(sweepstakes);

            //Console.WriteLine("Elements in stack: ");
            //foreach (Sweepstakes sweep in sweepQueue)
            //{
            //    Console.WriteLine(sweep.name);
            //}
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepToReturn = sweepQueue.Dequeue();
            return sweepToReturn;
        }
    }
}
