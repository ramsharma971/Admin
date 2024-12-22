using Microsoft.AspNetCore.Mvc;

namespace SCHOOL_ADMIN.Controllers
{
    public class StaffSection : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
