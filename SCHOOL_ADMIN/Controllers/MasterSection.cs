using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace SCHOOL_ADMIN.Controllers
{
    public class MasterSection : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Category(SCHOOL_CATEGORY model)
        //{
        //    return View();
        //}

        public IActionResult Religion()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Religion(SCHOOL_RELIGION model)
        //{
        //    return View();
        //}


    }
}
