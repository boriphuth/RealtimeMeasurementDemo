﻿using RealtimeMeasurement.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealtimeMeasurement.Web.Controllers
{
    public class HomeController : Controller
    {
        IApiMetrics apiMetrics;
        public HomeController(IApiMetrics apiMetrics)
        {
            this.apiMetrics = apiMetrics;
        }
        // GET: Home
        public ActionResult Index()
        {
            this.ViewBag.Title = "Home";
            this.ViewBag.HomeActive = "active";
            this.ViewBag.ProductActive = "";
            this.ViewBag.CartActive = "";
            apiMetrics.homePage();
            return View();
        }
    }
}