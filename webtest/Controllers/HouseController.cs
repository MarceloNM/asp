using Microsoft.AspNetCore.Mvc;

namespace webtest.Controllers
{
    public class HouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
