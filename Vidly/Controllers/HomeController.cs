﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Vidly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //Location =System.Web.UI.OutputCacheLocation.Server
        //[OutputCache(Duration =0 , VaryByParam ="*",NoStore =true)]
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}