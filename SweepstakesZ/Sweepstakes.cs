using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class Sweepstakes
    {
        //Member variables
        private string name;
        public  Dictionary<int, Contestant> registeredContestants;
        private Contestant winner;
        static int registrationNum;
        Random rand;


        //Properties
        public string Name { get => name; }
        public Contestant Winner { get => winner; }


        //Constructor
        public Sweepstakes(string Name)
        {
            this.name = Name;
            registeredContestants = new Dictionary<int, Contestant>();
            registrationNum = 1000;
            rand = new Random();
        }


        //Memebre Methods
        //Addes a passed in contestant to the list of registered for sweepstake
        public void RegisterContestant(Contestant contestant)
        {
            registeredContestants.Add(registrationNum, contestant);
            registrationNum++;
        }

        //Picks a winning contestant at random from the list of regisered contestants
        public Contestant PickWinner()
        {
            int winningNumber = 1001 + rand.Next(registeredContestants.Count);
            while (!registeredContestants.TryGetValue(winningNumber, out winner)) { }
            
            Console.WriteLine($"\nThe {name} sweepstakes winner is {winner.FirstName} {winner.LastName}!!");
            return winner;
        }


        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant Information:\n");
            Console.WriteLine($"First Name: {contestant.FirstName}");
            Console.WriteLine($"Last Name:  {contestant.LastName}");
            Console.WriteLine($"E-mail Address: {contestant.Email}");
            Console.WriteLine($"Registration #: {contestant.RegistrationNum}");
            if (Winner==null)
            {
                Console.WriteLine($"\n       Winner of the {name} sweepstakes not yet chosen.\n");
            }
            else if(winner.RegistrationNum == contestant.RegistrationNum)
            {
                Console.WriteLine($"\n       Winner of the {name} sweepstakes!\n");
            }
            else
            {
                Console.WriteLine($"\n       Did not win the {name} sweepstakes.\n");
            }
        }
    }
}
