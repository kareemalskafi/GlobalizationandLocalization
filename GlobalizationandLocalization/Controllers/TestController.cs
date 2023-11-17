using Microsoft.AspNetCore.Mvc;

namespace GlobalizationandLocalization.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
