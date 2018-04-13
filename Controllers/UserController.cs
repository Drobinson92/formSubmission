using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using formsubmission.Models;
namespace formsubmission.Controllers{
    public class UserController : Controller{
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.errors = ModelState.Values;
            return View();
        }
        [HttpPost]
        [Route("")]
        public IActionResult sendForm(string firstname, string lastname, int age, string email, string password){
            User newUser = new User{
                FirstName = firstname,
                LastName = lastname,
                Age = age,
                Email = email,
                Password = password
            };
            TryValidateModel(newUser);
            ViewBag.errors = ModelState.Values;
            if(TryValidateModel(newUser) == true){
                return View("Success");
            }
            return View("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}