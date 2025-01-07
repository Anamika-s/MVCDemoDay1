using Microsoft.AspNetCore.Mvc;

namespace MVCDemoDay1.Controllers
{
    public class FirstController : Controller
    {
       public IActionResult Index()
        {
            //if (1 == 1)
            //    return View();
            //else
            //    return Content("aaaa");
            return View();

        }

        public IActionResult ContactUs()
        {
            return View();
        }

    }
}
