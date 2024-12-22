using Microsoft.AspNetCore.Mvc;

namespace SCHOOL_ADMIN.Controllers
{
    public class AttendanceSection : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
