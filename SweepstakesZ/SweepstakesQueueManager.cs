using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //Memeber Variables
        Queue<Sweepstakes> sweepQueue = new Queue<Sweepstakes>();

        //Constructor
        public SweepstakesQueueManager()
        {

        }

        //Member Methods
        //Addes a passed in sweepstakes to the end od the queue
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepQueue.Enqueue(sweepstakes);
        }

        //Removes the First Sweepstakes added in the Queue and rerurns it
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepToReturn = sweepQueue.Dequeue();
            return sweepToReturn;
        }
    }
}
