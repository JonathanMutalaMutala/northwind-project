using Microsoft.AspNetCore.Mvc;

namespace northwind_project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
