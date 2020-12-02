using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contestant contestant6 = UserInterface.AddConstestant();
            //Contestant contestant7 = UserInterface.AddConstestant();
            Contestant contestant3 = UserInterface.AddConstestant("Smith", "Longbottom", "sipping@whisky.com");
            Contestant contestant4 = UserInterface.AddConstestant("James", "Cordin", "hates@whisky.com");
            Contestant contestant5 = UserInterface.AddConstestant("Katie", "Gladwell", "yummy@whisky.com");
            Contestant contestant1 = UserInterface.AddConstestant("Jim", "Beam", "drinks@whisky.com");
            Contestant contestant2 = UserInterface.AddConstestant("Bob", "Willbert", "chug@whisky.com");


        }
    }
}
