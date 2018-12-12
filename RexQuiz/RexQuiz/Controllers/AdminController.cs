using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RexQuiz.Controllers
{
    public class AdminController : Controller
    {
       
        
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult AddQuestion()
        {
            return View();
        }

        public IActionResult AddQuiz()
        {
            return View();
        }
        public IActionResult Quiz()
        {
            return View();
        }

        public IActionResult Invite()
        {
            return View();
        }

        public IActionResult ManageQuestion()
        {
            return View();
        }

        public IActionResult EditQuiz()
        {
            return View();
        }

        public IActionResult ManageQuiz()
        {
            return View();
        }
        public IActionResult PostArtical()
        {
            return View();
        }
    }
}