using Microsoft.AspNetCore.Mvc;
using webtest.Models;

namespace webtest.Controllers
{
    public class HabitacaoController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View(new Pessoa());
        }


        [HttpPost]
        public IActionResult Criar(Pessoa ppp)
        {

            Console.WriteLine(ppp.Nome);

            return View();
        }
    }
}
