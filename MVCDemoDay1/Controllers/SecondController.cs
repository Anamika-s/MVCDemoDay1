using Microsoft.AspNetCore.Mvc;

namespace MVCDemoDay1.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            TempData["name"] = "Deepak Kumar";
            TempData.Keep("name");
            ViewData["date"] = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            return View();
        }

        public IActionResult Index1()
        {
            TempData.Keep("name");
            ViewBag.date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            return View();
        }

        public IActionResult List()
        {
            List<string> list = new List<string>()

             {  "aaa", "bbb","ccc"};
            //ViewBag.list = list;
            ViewData["list"] = list;
            return View();
        }
    }
}
