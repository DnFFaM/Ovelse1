using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1.Code
{
    internal class Enrollment
    {
        public Student StudentInfo { get; set; }

        public Person PersonInfo { get; set; }

        public Course CourseInfo { get; set; }

        public Enrollment(Student studentInfo,Person personInfo ,Course courseInfo)
        {
            StudentInfo = studentInfo;
            PersonInfo = personInfo;
            CourseInfo = courseInfo;
        }
    }
}
