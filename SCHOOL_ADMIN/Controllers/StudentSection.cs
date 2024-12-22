using Microsoft.AspNetCore.Mvc;

namespace SCHOOL_ADMIN.Controllers
{
    public class StudentSection : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
