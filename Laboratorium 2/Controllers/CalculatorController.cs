using Laboratorium_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_2.Controllers
{
    public class CalculatorController : Controller
    {
        //public enum Operator
        //{
        //    Unknown, Add, Mul, Sub, Div
        //}
        //public IActionResult Result(Operator op, double a, double b)
        //{
        //    ViewBag.Op = op;
        //    ViewBag.A = a;
        //    ViewBag.B = b;

        //    if (a == null || b == 0 || op == Operator.Unknown)
        //    {
        //        ViewBag.Result = "Nie podałeś jakiegoś składnika ";
        //    }
        //    else
        //    {
        //        if (op == Operator.Add)
        //        {
        //            ViewBag.Result = a + b;
        //        }
        //        else if (op == Operator.Mul)
        //        {
        //            ViewBag.Result = a * b;
        //        }
        //        else if (op == Operator.Sub)
        //        {
        //            ViewBag.Result = a - b;
        //        }
        //        else if (op == Operator.Div)
        //        {
        //            if (b == 0)
        //            {
        //                ViewBag.Result = "Nie wolno dzielić przez 0!";
        //            }
        //            else
        //            {
        //                ViewBag.Result = a / b;
        //            }
        //        }
        //    }

        //    return View();
        //}

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result(Calculator calculator) 
        {
            if (!calculator.IsValid())
            {
                return View("Error");
            }
            return View(calculator);
        }
    }
}
