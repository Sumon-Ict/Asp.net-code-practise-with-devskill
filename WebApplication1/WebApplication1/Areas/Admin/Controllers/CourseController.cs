using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Areas.Admin.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        public IActionResult Index()
        {

            var model = new CourseListModel();
            model.LoadModelData();

            return View(model);
        }

        public IActionResult Enroll()
        {
            var model =new  EnrollStudentModel();
            return View(model);


        }
        [HttpPost]
        public IActionResult Enroll(EnrollStudentModel model)
        {
            if(ModelState.IsValid)
            {

            }
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Create()
        {
            return View();

        }
    }
}
