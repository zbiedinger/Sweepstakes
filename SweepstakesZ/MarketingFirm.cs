using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class MarketingFirm
    {
        //Member variabels
        private ISweepstakesManager manager;

        //Properties
        public ISweepstakesManager Manager { get => manager; }

        //Constructor
        //Dependency injection is used to allow either a Queue or
        //Stack data structure SweepstakesManager upon instantiating the 
        //MarketingFirm. This happens in the CreateMarketingFirmManager() method
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        //Member methods
        public void BeginSweepstakes()
        {
            //Contestant contestant6 = UserInterface.AddConstestant();
            Contestant contestant7 = UserInterface.AddConstestant();
            Contestant contestant3 = UserInterface.AddConstestant("Smith", "Longbottom", "sipping@whisky.com");
            Contestant contestant4 = UserInterface.AddConstestant("James", "Cordin", "hates@whisky.com");
            Contestant contestant5 = UserInterface.AddConstestant("Katie", "Gladwell", "yummy@whisky.com");
            Contestant contestant1 = UserInterface.AddConstestant("Jim", "Beam", "drinks@whisky.com");
            Contestant contestant2 = UserInterface.AddConstestant("Bob", "Willbert", "chug@whisky.com");

            Sweepstakes toyota = CreateSweepstakes("Toyota");
            Sweepstakes mcdonalds = CreateSweepstakes("McDonalds");
            Sweepstakes swimsuit = CreateSweepstakes("Swim Suit");
            
            toyota.RegisterContestant(contestant1);
            toyota.RegisterContestant(contestant2);
            toyota.RegisterContestant(contestant3);
            toyota.RegisterContestant(contestant4);
            toyota.RegisterContestant(contestant5);
            toyota.PrintContestantInfo(contestant5);            

            Contestant winner = toyota.PickWinner();

            Sweepstakes temp = manager.GetSweepstakes();
            temp.PrintContestantInfo(contestant2);

            //toyota.PrintContestantInfo(contestant1);
            //toyota.PrintContestantInfo(winner);
            
        }

        public Sweepstakes CreateSweepstakes(string name)
        {
            Sweepstakes newSweepstakes = new Sweepstakes(name);
            manager.InsertSweepstakes(newSweepstakes);
            
            return newSweepstakes;
        }
    }
}
