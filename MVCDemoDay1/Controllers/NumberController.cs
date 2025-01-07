using Microsoft.AspNetCore.Mvc;
using MVCDemoDay1.Models;

namespace MVCDemoDay1.Controllers
{
    public class NumberController : Controller
    {
        //public IActionResult AddNumbers()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AddNumbers(IFormCollection form)
        //{
        //    int num1 = byte.Parse(form["num1"]);
        //    int num2 = byte.Parse(form["num2"]);

        //    ViewBag.sum = num1 + num2;
        //    return View();
        //}



        public IActionResult AddNumbers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNumbers(int num1, int num2)
        {
          

            ViewBag.sum = num1 + num2;
            return View();
        }

        public IActionResult AddNumbers1()
        {
             return View();
        }
        [HttpPost]

        public IActionResult AddNumbers1(Numbers numbers)
        {
            ViewBag.sum = numbers.Num1 + numbers.Num2;
            return View();
        }

    }
}
