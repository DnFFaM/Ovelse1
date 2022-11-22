using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1.Code
{
    internal class Student : Person
    {
        public int StudentId { get; set; }


        public Student(int studentId) : Person(string? firstName, string? lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            StudentId = studentId;
        }
    }
}
