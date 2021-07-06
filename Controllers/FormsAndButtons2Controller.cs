using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRandomHTMLColor.Models;

namespace WebApplicationRandomHTMLColor.Controllers
{
    //[Route("")]
    //routes can also be applied at the controller level
    public class FormsAndButtons2Controller : Controller
    {
        public IActionResult Index(string s = "dog") //dog is the default string if no param is passed via url
        {
            ViewBag.s = s;
            return View(Repo.AllStudents);

        //navigate to https://localhost:44346/FormsAndButtons2?s=cat to see parameter usage
        }

        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult RegisterStudent(int id, string fName, string lName)
        {
           
            Repo.Create(new Student(id, fName, lName));
            return View("Index", Repo.AllStudents);
        }

        [Route("FormsAndButtons2/About/{year:int}/{key?}")] 
        public IActionResult Post(int year, string key = "doggo") // "doggo" is the default if no param 
        {                                                         // ? means optional
            ViewBag.s = year + "/"  + key;
            //return new ContentResult { Content = year + "/" + key };
            return View();

            //navigate to https://localhost:44346/FormsAndButtons2/About/1999/key121
        }

        public IActionResult FormsAgain() 
        {
            Student s = new Student(123, "Frank", "SmellyCat");
            return View(s);
        }

       
    }
}
