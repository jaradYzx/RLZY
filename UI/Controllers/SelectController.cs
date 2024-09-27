using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class SelectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KB()
        {
            return View();
        }
    }
}
