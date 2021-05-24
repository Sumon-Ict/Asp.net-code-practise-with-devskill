using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApplication.Controllers
{
    public class ItemController : Controller
    {
       public IActionResult Index()
        {

            ViewBag.Message = "this is view page meassge ";


            return View();

        }
        public IActionResult Index1()
        {
            return View();
        }
            
    }
}
