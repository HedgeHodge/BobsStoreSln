using Microsoft.AspNetCore.Mvc;

namespace OutdoorProducts.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
