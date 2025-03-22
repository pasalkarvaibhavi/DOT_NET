using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult TechSkills() => View();
        public IActionResult Download() => View();
    }
}
