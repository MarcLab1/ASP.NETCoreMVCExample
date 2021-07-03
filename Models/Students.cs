using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRandomHTMLColor.Models;

namespace WebApplicationRandomHTMLColor.Models
{
    public class Students
    {
        private List<Student> students;
        public Students()
        {
            students = new List<Student>();
        }

        public void addStudent(Student s)
        {
            students.Add(s);
        }

        public List<Student> getStudents()
        {
            return students;
        }

        public int getCount()
        {
            return students.Count;
        }

        public Student getStudent(int index)
        {
            return students[index];
        }

    }
}
