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

        public List<string> GetStudentsList(List<Enrollment> list)
        {
            List<string> _studentsList = new List<string>();

            foreach (var item in list)
            {
                if (item.CourseInfo.CourseName == CourseName)
                {
                    _studentsList.Add(item.StudentInfo.FirstName);
                }
            }
            return _studentsList;
        }

        public void CourseStudentAmoutCheck(List<string> _studentList)
        {
            if (_studentList.Count < 8)
            {
                throw new Exception("Less then 8 Student");
            }
            else if (_studentList.Count > 16)
            {
                throw new Exception("More then 16 Student");
            }
        }
    }

}
