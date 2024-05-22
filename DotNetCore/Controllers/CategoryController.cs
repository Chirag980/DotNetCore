using DotNetCore.Data;
using DotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();//This code will run like Select * from Category Table it is for getting the all the data from the parrticular model or table
            return View(objCategoryList);
        }
        public IActionResult CreateCategory()
        {
            return View();
        }
    }
}
