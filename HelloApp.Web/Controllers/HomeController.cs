using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
