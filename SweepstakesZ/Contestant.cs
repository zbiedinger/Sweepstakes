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
        private string FirstName;
        private string LastName;
        private string Email;
        private int RegistrationNum;

        //Properties
        public string firstName { get => FirstName; }
        public string lastName { get => LastName; }
        public string email { get => Email; set => Email = value; }
        public int registrationNum { get => RegistrationNum; }


        //Constructor
        public Contestant(string firstName, string lastName, string Email, int registrationNum)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.email = Email;
            this.RegistrationNum = registrationNum;
        }

        //Member Method



        //public int GetNextValue()
        //{
        //    return System.Threading.Interlocked.Increment(ref this.value);
        //}
        
    }
}
