using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RexQuiz.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }
        public IActionResult StartQuiz()
        {
            return View();
        }
    }
}