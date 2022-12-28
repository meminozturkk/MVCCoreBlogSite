using Microsoft.AspNetCore.Mvc;

namespace MVCCoreBlogSite.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
