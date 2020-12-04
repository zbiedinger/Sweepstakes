using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class Simulation
    {
        //Member Variables
        MarketingFirm myMarketingFirm;
        
        //Constructor
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
                myMarketingFirm.BeginSweepstakes();
               
                willProceed = UserInterface.ContinuePrompt("Continue to next Sweepstake?");
                Console.Clear();
            }

        }

        //Instantiates a SweepstakesManager of Stack or Queue type
        //based on user input with a factory pattern
        public void CreateMarketingFirmManager()
        {
            ISweepstakesManager sweepManager;
            Console.WriteLine("What type of manager do you want?\n" +
                "1. Stack     2. Queue");

            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "1":
                case "stack":
                     sweepManager = new SweepstakesStackManager();
                    CreateMarketingFirm(sweepManager);

                    break;
                case "2":
                case "queue":
                    sweepManager = new SweepstakesQueueManager();
                    CreateMarketingFirm(sweepManager);
                    break;
                default:
                    Console.WriteLine("\nInvalid input");
                    Console.WriteLine("\nWhat ype of manager do you want?\n" +
                "1. Stack     2. Queue");
                    break;
            }
        }

        //Instantiates a MarketingFirm with the data structure of 
        //passed SweepstakesManger.
        public void CreateMarketingFirm(ISweepstakesManager managerType)
        {
            myMarketingFirm = new MarketingFirm(managerType);
        }
    }
}
