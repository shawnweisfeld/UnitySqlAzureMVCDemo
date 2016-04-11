﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private Repositories.ITestRepository _test;

        public HomeController(Repositories.ITestRepository test)
        {
            _test = test;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = $"Your contact page. {_test.GetTime()}";

            return View();
        }
    }
}