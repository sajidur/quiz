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

      
    }
}