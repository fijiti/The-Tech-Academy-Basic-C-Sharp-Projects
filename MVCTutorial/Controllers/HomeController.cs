﻿using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{   
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;

            return View(user);

         
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id=10)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}