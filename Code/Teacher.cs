using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1.Code;

internal class Lærer : Person
{
    public string Department { get; set; }     

   public double Age
   {
        get;
        private set;
   }

    public Lærer(string department,string firstName,string lastName,DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth)
    {
        Department = department;
    }
}

                      