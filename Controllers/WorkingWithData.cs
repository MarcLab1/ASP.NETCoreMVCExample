using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRandomHTMLColor.Models;

namespace WebApplicationRandomHTMLColor.Controllers
{
    public class WorkingWithData : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, Route("WorkingWithData/Show")]
        public IActionResult Show(int id, string fName, string lName)
        {
            Student s = new Student(id, fName, lName);
            return View(s);
        }

       /* public class CreateStudentRequest
        {
            public string fName { get; set; }
            public string lName { get; set; }
        }*/

    }
}
