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

        public Simulation()
        {
            GetterDoneMarketing = new MarketingFirm();
        }


        //Member Methods
        public void Simulate()
        {
            bool willProceed = true;
            while (willProceed)
            {
                GetterDoneMarketing.BeginSweepstakes();
                willProceed = UserInterface.ContinuePrompt("Continue to next transaction?");
                Console.Clear();
            }

        }
    }
}
