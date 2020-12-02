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
        private Dictionary<int, Contestant> registeredContestants;
        private Contestant Winner;
        static int registrationNum;

        Random rand;

        //Properties
        public string name { get => Name; }
        public Dictionary<int, Contestant> RegisteredContestants { get => registeredContestants; }


        //Constructor
        public Sweepstakes(string Name)
        {
            this.Name = Name;
            registeredContestants = new Dictionary<int, Contestant>();
            registrationNum = 1;
            rand = new Random();
        }


        //Memebre Methods
        //Addes a passed in contestant to the list of registered for sweepstake
        public void RegisterContestant(Contestant contestant)
        {
            registeredContestants.Add(registrationNum, contestant);
            registrationNum++;
            Console.WriteLine($"\n{contestant.firstName} {contestant.lastName} has" +
                $" been registered for the {name} sweepstakes!");
        }

        //Picks a winning contestant at random from the list of regisered contestants
        public Contestant PickWinner()
        {
            int winningNumber = 1 + rand.Next(registeredContestants.Count);
            
            while (!RegisteredContestants.TryGetValue(winningNumber, out Winner)) { }
            
            Console.WriteLine($"\nThe {name} sweepstakes winner is {Winner.firstName} {Winner.lastName}!!");
            return Winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant Information:\n");
            Console.WriteLine($"First Name: {contestant.firstName}");
            Console.WriteLine($"Last Name: {contestant.lastName}");
            Console.WriteLine($"E-mail Address: {contestant.email}");
            Console.WriteLine($"Registration #: {contestant.registrationNum}\n");
        }
    }
}
