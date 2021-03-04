using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class TeachingStaff
    {
        public int RegistrationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
      

        public override string ToString()
        {
            return $" {RegistrationNumber,5} " +
                $" {FirstName,5} " +
                $" {LastName,5} " +
                string.Format("{0,5}", Gender == true ? "Erkek" : "Kadın");
                    
        }
    }
}
