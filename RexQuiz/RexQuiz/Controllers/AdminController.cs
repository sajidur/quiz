using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RexQuiz.Models;

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

            IEnumerable<Quiz> students = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64189/api/values");
                //HTTP GET
                var responseTask = client.GetAsync("");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Quiz>>();
                    readTask.Wait();

                    students = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    students = Enumerable.Empty<Quiz>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }

                return View();
            }
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