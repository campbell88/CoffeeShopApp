using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShopApp.Models;

namespace CoffeeShopApp.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult UserRegistration()
        {
           
            return View();
        }
        public ActionResult AddUser(UserInfo NewUser)
        {
            
          
            return View(NewUser);  //pass the NewUser model to the AddUser view

        }
    }
}