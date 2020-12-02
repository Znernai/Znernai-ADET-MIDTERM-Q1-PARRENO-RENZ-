using app.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentService studentService;

        public HomeController(ILogger<HomeController> logger, IStudentService stud)
        {
            _logger = logger;
            studentService = stud;
        }

        public IActionResult Index()
        {
            var temp = studentService.GetStudentByNumber(new app.service.Students.Query.GetStudentByNumber.GetStudentByNumberQuery { StudentNumber = "1234" });
            return View();
        }

        public IActionResult Privacy()
        {
            var temp = studentService.CreateStudent(new app.service.Students.Commands.CreateStudent.CreateStudentCommand
            {
                Name = "Test",
                StudentNumber = "1234"
            });
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
