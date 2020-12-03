using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class Simulation
    {
        MarketingFirm GetterDoneMarketing;
        ISweepstakesManager sweepManager;
        

        public Simulation()
        {

        }


        //Member Methods
        public void Simulate()
        {
            bool willProceed = true;
            while (willProceed)
            {
                UserInterface.Setup();
                CreateMarketingFirmManager();
                GetterDoneMarketing = new MarketingFirm(sweepManager);

                GetterDoneMarketing.BeginSweepstakes();
               
                willProceed = UserInterface.ContinuePrompt("Continue to next Sweepstake?");
                Console.Clear();
            }

        }
        public void CreateMarketingFirmManager()
        {
            Console.WriteLine("What type of manager do you want?\n" +
                "1. Stack     2. Queue");

            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "1":
                case "stack":
                    sweepManager = new SweepstakesStackManager();
                    break;
                case "2":
                case "queue":
                    sweepManager = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("\nInvalid input");
                    Console.WriteLine("\nWhat ype of manager do you want?\n" +
                "1. Stack     2. Queue");
                    break;
            }
        }
    }
}
