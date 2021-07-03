using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRandomHTMLColor.Models;

namespace WebApplicationRandomHTMLColor.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student s1 = new Student(12, "Mak", "Ten");
            Student s2 = new Student(13, "Jin", "Wang");
         
            ViewData["s1"] = s1;
            ViewData["s2"] = s2;

            return View();
        }

        public IActionResult Student()
        {
            Student s1 = new Student(12, "Mak", "Ten");
            Student s2 = new Student(13, "Jin", "Wang");
            Students students = new Students();
            students.addStudent(s1);
            students.addStudent(s2);

            ViewData["students"] = students;

            return View();
        }

        public IActionResult Show()
        {
            Student student = new Student(123, "Testing", "Hoping");

            return View(student);
        }

    }
}
