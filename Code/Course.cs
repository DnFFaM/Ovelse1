using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1.Code
{
    internal class Course : Person
    {
        public string? CourseName;
        public string? TeacherInfo;

        public Course(string? coursename, string? teacherinfo)
        {
            CourseName = coursename;
            TeacherInfo = teacherinfo;
        }
    }

}
