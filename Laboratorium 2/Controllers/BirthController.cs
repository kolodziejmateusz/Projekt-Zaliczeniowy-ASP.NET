using Laboratorium_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result([FromForm] Birth birth)
        {
            if (!birth.IsValid()) 
            {
                return View("Error");
            }
            return View(birth);
        }
    }
}
