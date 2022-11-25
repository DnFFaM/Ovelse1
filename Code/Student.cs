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


        public override string GetAllCourse(Enrollment enrollment)
        {
            StringBuilder sb = new();
            sb.Append($"{FirstName}\n\n");
            foreach (var item in enrollment.ListAftilmedt)
            {
                if (item.StudentInfo.StudentId == StudentId)
                {
                    sb.Append($"{item.CourseInfo.CourseName}\n");
                }
            }

            return sb.ToString();
        }
        public override List<string> GetAllCourse(List<Enrollment> enrollment)
        {
            List<string> _enrollment = new();
            foreach (var item in enrollment)
            {
                if (item.StudentInfo.FirstName == FirstName)
                {
                    _enrollment.Add(item.CourseInfo.CourseName.ToString());
                }
            }
            return _enrollment;
        }

        public override string? GetNames()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
