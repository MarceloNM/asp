using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using webtest.Models;

namespace webtest.Controllers
{
    public class LarController : Controller
    {
        public IActionResult Index()
        {
            /*    Pessoa ppp = new Pessoa();
                ppp.Nome = "António";
                ppp.Email = "antonio@gmail.com";
                return View(ppp); */
            // Pessoa ppp = new Pessoa();
            string connStr = "server=localhost;user=root;database=asptest;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            List<Pessoa> modelo = new List<Pessoa>(5);

            /*
            var model = db.Employees.Select(x => new EmployeeViewModel
            {
                ID = x.id,
                Name = x.Name
            }).ToList();

            return View(model); */

            try
            {
                Console.WriteLine("Ligar ao MySQL...");
                conn.Open();
                string sql = "select * from aspum;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    Pessoa ppp = new Pessoa();
                    Console.WriteLine(rdr[0]);
                    Console.WriteLine(rdr[1]);
                    Console.WriteLine(rdr[2]);
                    Console.WriteLine(rdr[3]);
                    ppp.Id = (int)rdr[0];
                    ppp.Nome = (string)rdr[1];
                    ppp.Email = (string)rdr[2];
                    ppp.Tefone = (string)rdr[3];
                    modelo.Add(ppp);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Concluído");
            return View(modelo);
        }
    }
}
