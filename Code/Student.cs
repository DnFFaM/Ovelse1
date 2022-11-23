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


        public Student(int studentId, string firstName, string lastName, DateTime dateOfbirth) : base(firstName, lastName, dateOfbirth)
        {
            StudentId = studentId;
        }


        internal override string GetAllCourses(Enrollment meow)
        {
            if (meow == null)
            {
                return "";
            }
            else
            {
                return "";
            }
        }

 

    }
}
