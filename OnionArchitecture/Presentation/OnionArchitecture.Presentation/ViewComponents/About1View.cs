using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Presentation.ViewComponents
{
    public class About1View: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
