using Microsoft.AspNetCore.Mvc;

namespace University.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentsDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
