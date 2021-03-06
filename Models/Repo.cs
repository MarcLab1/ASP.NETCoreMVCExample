using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationRandomHTMLColor.Models
{
    public static class Repo
    {
        private static List<Student> allStudents = new List<Student>();
        public static IEnumerable<Student> AllStudents
        {
            get { return allStudents; }
        }
        public static void Create(Student student)
        {
            allStudents.Add(student);
        }

        public static void Remove(Student student)
        {
            allStudents.Remove(student);
        }
    }
}
