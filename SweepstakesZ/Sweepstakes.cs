using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class Sweepstakes
    {
        //member variables
        private string Name;
        private List<Contestant> resgisteredContestants;
        private Contestant Winner;
        Random rand;

        //Properties
        public string name { get => Name; }
        public List<Contestant> Contestants { get => resgisteredContestants; }

        //Constructor
        public Sweepstakes(string Name)
        {
            this.Name = Name;
            resgisteredContestants = new List<Contestant>();
            rand = new Random();
        }


        //Memebre Methods
        //Addes a passed in contestant to the list of registered for sweepstake
        public void RegisterContestant(Contestant contestant)
        {
            resgisteredContestants.Add(contestant);
            Console.WriteLine($"\n{contestant.firstName} {contestant.lastName} has" +
                $" been registered for the {name} sweepstakes!");
        }

        //Picks a winning contestant at random from the list of regisered contestants
        public Contestant PickWinner()
        {
            int winningNumber = 1 + rand.Next(resgisteredContestants.Count);

            foreach (Contestant contestant in resgisteredContestants)
            {
                if(winningNumber == contestant.registrationNum)
                {
                    Winner = contestant;
                }
            }
            Console.WriteLine($"\nThe {name} sweepstakes winner is {Winner.firstName} {Winner.lastName}!!");
            return Winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
