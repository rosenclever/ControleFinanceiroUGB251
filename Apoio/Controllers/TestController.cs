using Microsoft.AspNetCore.Mvc;

namespace Apoio.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
