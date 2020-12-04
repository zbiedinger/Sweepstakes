using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesZ
{
    class Contestant
    {
        //Member Variables
        private string firstName;
        private string lastName;
        private string email;
        private int registrationNum;


        //Properties
        public string FirstName { get => firstName; }
        public string LastName { get => lastName; }
        public string Email { get => email; set => email = value; }
        public int RegistrationNum { get => registrationNum; }


        //Constructor
        public Contestant(string firstName, string lastName, string Email, int registrationNum)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = Email;
            this.registrationNum = registrationNum;
        }
    }
}
