using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopApp.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult UserRegistration()
        {
           
            return View();
        }
        public ActionResult AddUser(string firstName)
        {
            
            ViewBag.FirstName = firstName;
            return View();

        }
    }
}