using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace RedisApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpContext.Session.SetString("Chave", $"Data: {DateTime.Now}");
            return View();
        }

        public IActionResult About()
        {
            var valor = HttpContext.Session.GetString("Chave");

            ViewData["Message"] = $"Your application description page. {valor}";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
