using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stocker.Models;

namespace Stocker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            User u = new User();
            u.Email = "admin@stocker.co.uk";
            u.Password = "password1231";


            //establish connection
            using (SqlConnection connection = new SqlConnection("ha!"))
            {
                //create a command to send to the database
                using (SqlCommand cmd = new SqlCommand("spAuthenticateUser", connection))
                {
                    //adapt the command to use a stored procedure with parameters.
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.VarChar));
                    adapter.SelectCommand.Parameters["@Email"].Value = u.Email;
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@Password", System.Data.SqlDbType.VarChar));
                    adapter.SelectCommand.Parameters["@Password"].Value = u.Password;

                    //bool correct = UserManager.Authenticate(Email,Password)
                    //
                    //If(correct) = Login else unable to login

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        ViewBag.User = "Logged In";
                    }
                    else
                    {
                        ViewBag.User = "Unable to Login";
                    }
                }
            }


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
