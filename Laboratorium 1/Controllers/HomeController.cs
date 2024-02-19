using Laboratorium_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium_1.Controllers
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
            return View();
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

        public IActionResult About()
        {
            return View();
        }

        public enum Operator
        {
            Unknown, Add, Mul, Sub, Div
        }

        public IActionResult Calculator(Operator op, double? a, double? b) 
        {
            ViewBag.Op = op;
            ViewBag.A = a;
            ViewBag.B = b;

            if (a ==  null || b == 0 || op == Operator.Unknown) 
            {
                ViewBag.Result = "Nie podałeś jakiegoś składnika ";
            }
            else
            {
                if (op == Operator.Add)
                {
                    ViewBag.Result = a + b;
                }
                else if (op == Operator.Mul)
                {
                    ViewBag.Result = a * b;
                }
                else if (op == Operator.Sub)
                {
                    ViewBag.Result = a - b;
                }
                else if (op == Operator.Div)
                {
                    if (b == 0)
                    {
                        ViewBag.Result = "Nie wolno dzielić przez 0!";
                    }
                    else
                    {
                        ViewBag.Result = a / b;
                    }
                }
            }


            return View();
        }
    }
}
