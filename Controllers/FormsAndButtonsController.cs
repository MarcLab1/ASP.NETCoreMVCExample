using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRandomHTMLColor.Models;

namespace WebApplicationRandomHTMLColor.Controllers
{
    public class FormsAndButtonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IndexOne()
        {
            ViewData["Message"] = "clogs";
            return View("ShowAllStudents", Repo.AllStudents);
        }

        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult IndexTwo(Student s)
        {
            ViewData["Message"] = "dogs";
            Repo.Create(s);
            return View("ShowAllStudents", Repo.AllStudents);
        }

        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult IndexThree(int id, string fName, string lName)
        {
            ViewData["Message"] = "frogs";
            Repo.Create(new Student(id, fName, lName));
            return View("ShowAllStudents", Repo.AllStudents);
        }
    }
}
