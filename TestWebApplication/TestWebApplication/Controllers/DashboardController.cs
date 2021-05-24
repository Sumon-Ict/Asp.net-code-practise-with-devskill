using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApplication.Controllers
{
    public class DashboardController : Controller
    {
       /* public IActionResult Index()
        {
            return View();
        }
        */

        public ViewResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";
            return View();
        }

       public IActionResult Index1()
        {
            return View();

        }

        public IActionResult About()
        {
            ViewBag.FirstValue = "Hello World";
            ViewBag.SecondValue = "Hello ViewBag";
            ViewBag.ThirdValue = "How are you!";

            ViewData["name"] = "my name is sumon";
            ViewData["home"] = "home district bogura";
            ViewData["id"] = 123788899;

            return View();

        }


    }
}
