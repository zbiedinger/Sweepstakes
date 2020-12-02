using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class MarketingFirm
    {


        public MarketingFirm()
        {

        }

        public void BeginSweepstakes()
        {
            //Contestant contestant6 = UserInterface.AddConstestant();
            //Contestant contestant7 = UserInterface.AddConstestant();
            Contestant contestant3 = UserInterface.AddConstestant("Smith", "Longbottom", "sipping@whisky.com");
            Contestant contestant4 = UserInterface.AddConstestant("James", "Cordin", "hates@whisky.com");
            Contestant contestant5 = UserInterface.AddConstestant("Katie", "Gladwell", "yummy@whisky.com");
            Contestant contestant1 = UserInterface.AddConstestant("Jim", "Beam", "drinks@whisky.com");
            Contestant contestant2 = UserInterface.AddConstestant("Bob", "Willbert", "chug@whisky.com");

            Sweepstakes toyota = CreateSweepstakes("Toyota");

            toyota.RegisterContestant(contestant1);
            toyota.RegisterContestant(contestant2);
            toyota.RegisterContestant(contestant3);
            toyota.RegisterContestant(contestant4);
            toyota.RegisterContestant(contestant5);

            Contestant winner = toyota.PickWinner();
        }

        public Sweepstakes CreateSweepstakes(string name)
        {
            Sweepstakes newSweepstakes = new Sweepstakes(name);
            return newSweepstakes;
        }
    }
}
