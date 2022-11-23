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


        public Course CourseInfo { get; set; }

        public Enrollment ListAftilmedt { get; set; }

        public Enrollment()
        {

        }

             
        public Enrollment(Student studentInfo, Course courseInfo)
        {
            StudentInfo = studentInfo;
            CourseInfo = courseInfo;
        }
    }
}

