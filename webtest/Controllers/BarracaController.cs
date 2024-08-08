using Microsoft.AspNetCore.Mvc;

namespace webtest.Controllers
{
    public class BarracaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
