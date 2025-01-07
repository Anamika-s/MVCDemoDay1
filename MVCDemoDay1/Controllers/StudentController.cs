using Microsoft.AspNetCore.Mvc;
using MVCDemoDay1.Models;
namespace MVCDemoDay1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            Student student = new Student()
            {
                Rn = 1,
                Name = "Ajay",
                Batch = "B001",
                Marks = 90
            };
            ViewBag.student = student;
            return View();
        }
        public IActionResult Details1()
        {
            Student student = new Student()
            {
                Rn = 1,
                Name = "Ajay",
                Batch = "B001",
                Marks = 90
            };
            
            return View(student);
        }


        public IActionResult Index()
        {
           List<Student> students = null;
                 if (students == null)
                {
                    students = new List<Student>()
                {
                     new Student() { Rn=1, Name="Ajay", Batch="B001", Marks=90},
                     new Student() { Rn=2, Name="Vijay", Batch="B001", Marks=90},
                     new Student() { Rn=3, Name="Jay", Batch="B001", Marks=90},
                     new Student() { Rn=4, Name="Deepak", Batch="B001", Marks=90},
                     new Student() { Rn=5, Name="Sagar", Batch="B001", Marks=90},
                };
                }

                 ViewBag.list = students; 
            return View();
            }


        public IActionResult Hello()
        {
            return View();
        }
        public IActionResult Index1()
        {
            List<Student> students = null;
            if (students == null)
            {
                students = new List<Student>()
                {
                     new Student() { Rn=1, Name="Ajay", Batch="B001", Marks=90},
                     new Student() { Rn=2, Name="Vijay", Batch="B001", Marks=90},
                     new Student() { Rn=3, Name="Jay", Batch="B001", Marks=90},
                     new Student() { Rn=4, Name="Deepak", Batch="B001", Marks=90},
                     new Student() { Rn=5, Name="Sagar", Batch="B001", Marks=90},
                };
            }

             
            return View(students);
        }
    }
    }

