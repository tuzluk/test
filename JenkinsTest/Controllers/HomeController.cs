﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JenkinsTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index()
        {
            var hede = new DateTime("Murat2");
            return "Hello World";
        }
    }
}