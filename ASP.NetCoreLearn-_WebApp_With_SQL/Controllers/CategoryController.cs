using Microsoft.AspNetCore.Mvc;

namespace ASP.NetCoreLearn__WebApp_With_SQL.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
