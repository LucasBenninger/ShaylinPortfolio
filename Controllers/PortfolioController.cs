using Microsoft.AspNetCore.Mvc;

namespace ShayPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Categories()
        {
            return View();
        }

        public IActionResult DigitalArt()
        {
            return View();
        }

        public IActionResult Photography()
        {
            return View();
        }

        public IActionResult MixedMedia()
        {
            return View();
        }
    }
}