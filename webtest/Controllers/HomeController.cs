using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using webtest.Models;

namespace webtest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
        /*    Pessoa ppp = new Pessoa();
            ppp.Nome = "António";
            ppp.Email = "antonio@gmail.com";
            return View(ppp); */
            Pessoa ppp = new();
            string connStr = "server=localhost;user=root;database=asptest;port=3306;password=";
            MySqlConnection conn = new(connStr);
            try
            {
                Console.WriteLine("Ligar ao MySQL...");
                conn.Open();
                string sql = "select * from aspum;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    Console.WriteLine(rdr[1]);
                    ppp.Nome = (string)rdr[1];
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Concluído");
            return View(ppp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}