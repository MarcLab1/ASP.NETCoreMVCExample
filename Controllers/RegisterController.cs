using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationRandomHTMLColor.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index(string left, string right)
        {
            ViewData["FirstMessage"] = "";
            ViewData["SecondMessage"] = "";

            if (!string.IsNullOrEmpty(left))
            {
                ViewData["FirstMessage"] = "You clicked left";
                ViewData["SecondMessage"] = "you did";
            }
            if (!string.IsNullOrEmpty(right))
            {
                ViewData["FirstMessage"] = "You clicked right";
                ViewData["SecondMessage"] = "are you ok?";
            }
            return View();
        }

        public IActionResult Welcome(string left = "nono", string right = "yesyes")
        {
            ViewData["FirstMessage"] = left;
            ViewData["SecondMessage"] = right;
            return View();
        }

    }
}
