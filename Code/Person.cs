using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1.Code;

internal abstract class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public abstract string GetAllCourse(Enrollment enrollment);

    public abstract List<string> GetAllCourse(List<Enrollment> enrollment);

    public virtual string? GetNames()
    {
        return $"{FirstName} {LastName}";
    }



}
