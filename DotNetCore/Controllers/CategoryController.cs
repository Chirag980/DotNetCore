using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
