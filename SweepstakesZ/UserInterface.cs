﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    static class UserInterface
    {
        static int registrationNum = 0;

        //Setup
        public static void Setup()
        {
            Console.WriteLine("\nWelcome to your very own sweepstakes starter kit!");
            bool istrue = ContinuePrompt("Are you ready to get started ? (y/n)");
            if (!istrue)
            {
                Console.WriteLine("To bad we are going anyways.\n");
            }
        }


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

        //Changes a passed contestants email address with user input
        public static void ChangeEmail(Contestant contestant)
        {
            Console.WriteLine("\nEnter updated email address:");
            contestant.Email = Console.ReadLine();
            Console.WriteLine($"\n{contestant.FirstName}'s email address has been changed to {contestant.Email}");
        }

        //Used for any user prompts that use a yes or now format.
        public static bool ContinuePrompt(string output)
        {
            Console.WriteLine(output);
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "y":
                case "yes":
                    return true;
                case "n":
                case "no":
                    return false;
                default:
                    Console.WriteLine("\nInvalid input");
                    return ContinuePrompt(output);
            }
        }
    }
}
