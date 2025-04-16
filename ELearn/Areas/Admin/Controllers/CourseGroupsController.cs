using Microsoft.AspNetCore.Mvc;

namespace ELearn.Areas.Admin.Controllers
{
    public class CourseGroupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
