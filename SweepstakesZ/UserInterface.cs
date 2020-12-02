using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    static class UserInterface
    {
        static int registrationNum = 0;


        //Creates a contestant from userinput
        public static Contestant AddConstestant()
        {
            Console.WriteLine("\nEnter first and last name:");
            string[] name = Console.ReadLine().Split(' ');
            string firstname = name[0];
            string lastname = name[1];

            Console.WriteLine("\nEnter e-mail address:");
            string emailAddress = Console.ReadLine();

            registrationNum++;

            Contestant newContestant = new Contestant(firstname, lastname, emailAddress, registrationNum);
            return newContestant;
        }
        //creates a contestant from passed values
        public static Contestant AddConstestant(string firstname, string lastname, string emailAddress)
        {
            registrationNum++;

            Contestant newContestant = new Contestant(firstname, lastname, emailAddress, registrationNum);
            return newContestant;
        }

        public static void ChangeEmail(Contestant contestant)
        {
            Console.WriteLine("\nEnter updated email address:");
            contestant.email = Console.ReadLine();
            Console.WriteLine($"\n{contestant.firstName}'s email address has been changed to {contestant.email}");
        }
    }
}
