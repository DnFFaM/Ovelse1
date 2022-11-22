using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1.Code;

internal class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? DateOfBirth { get; set; }

    public Person(string firstName, string lastName, int dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
}
