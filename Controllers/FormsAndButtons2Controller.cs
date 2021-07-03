using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRandomHTMLColor.Models;

namespace WebApplicationRandomHTMLColor.Controllers
{
    public class FormsAndButtons2Controller : Controller
    {
        public IActionResult Index()
        {
            return View(Repo.AllStudents);
        }

        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult RegisterStudent(int id, string fName, string lName)
        {
           
            Repo.Create(new Student(id, fName, lName));
            return View("Index", Repo.AllStudents);
        }

    }
}
