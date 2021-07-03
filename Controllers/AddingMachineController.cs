using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationRandomHTMLColor.Controllers
{
    public class AddingMachineController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                double num1 = Convert.ToDouble(HttpContext.Request.Form["Text1"].ToString());
                double num2 = Convert.ToDouble(HttpContext.Request.Form["Text2"].ToString());

                ViewBag.Result = (num1 + num2).ToString();
            }
            catch (Exception)
            {
                ViewBag.Result = "Enter 2 values, then click the = button";
            }
            return View();
        }

    }
}
