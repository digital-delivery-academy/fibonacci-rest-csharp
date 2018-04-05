using Microsoft.AspNetCore.Mvc;

namespace fibonacci_csharp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger/");
        }
    }
}