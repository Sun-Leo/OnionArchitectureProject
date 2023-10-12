using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Presentation.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
