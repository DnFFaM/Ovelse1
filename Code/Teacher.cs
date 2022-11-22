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

        public Lærer( string firstName, string lastName, DateTime dateOfBirth, int? department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }
    }

}
