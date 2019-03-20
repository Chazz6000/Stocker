using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocker.Models;
using Stocker.Repositories.Abstract;

namespace Stocker.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUserRepository _UserRepository;

        public HomeController(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }


        public IActionResult Index()
        {
            User u = new User();
            u.Email = "admin@stocker.co.uk";
            u.Password = "password";

           User test =  _UserRepository.Authenticate(u.Email, u.Password);
           

            if (test != null)
            {
                ViewBag.User = "Logged In";
            }
            else
            {
                ViewBag.User = "No User Found";
            }

            //establish connection

           return View();
        }

       public IActionResult Auth(User u)
        {

          User user =  _UserRepository.Authenticate(u.Email, u.Password);

            if (user != null)
            {
                return View("LoggedIn");
            }
            else
            {
                return View("Index");
            }


        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
