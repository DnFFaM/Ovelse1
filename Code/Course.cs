using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1.Code
{
    internal class Course 
    {
        public string CourseName { get; set; }
        public Lærer TeacherInfo { get; set; }

        public Course(string courseName, Lærer teacherInfo)
        {
            CourseName = courseName;
            TeacherInfo = teacherInfo;
        }


    }

}
