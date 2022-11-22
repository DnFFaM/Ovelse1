using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1.Code
{
    internal class Lærer : Person
    {
       public int? Department;

       public double Age
       {
            get;
            private set;
       }

        public Lærer(string department) : Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            Department = department;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Age = Logics.CalculateAge(dateOfBirth);
        }
    }

}
