using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RexQuiz.Models;

namespace RexQuiz.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string userName,string password)
        {
           // userName = "z@gmail.com";password = "Zahid1234*";
            if (userName=="admin"&& password=="admin")
            {
                return RedirectToAction("Dashboard", "Admin");

            }
            using (var client = new HttpClient())
            {
                string url = "userName="+ userName+"&password="+password;
                client.BaseAddress = new Uri("http://sajidur-001-site3.itempurl.com/api/Account/Login?" + url);

                var postTask = client.PostAsync("",null);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Student");
                }
            }
            return View();
        }

        public IActionResult Register()
        {
            ViewData["a"] = "zzzz";
            return View();
        }

        [HttpPost]
        public IActionResult Register(Account account)
        {
            using (var client =new HttpClient())
            {
                client.BaseAddress=new Uri("http://sajidur-001-site3.itempurl.com/api/Account/Register");

                var postTask = client.PostAsJsonAsync<Account>("account", account);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return Redirect("Index");
                }
            }
            ModelState.AddModelError(String.Empty, "Server Error.");
            //ViewData["a"] = "jabjf";
            return View();
        }
    }
}