﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAppLog.Models;

namespace WebAppLog.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> Logger { get; }
        public HomeController(ILogger<HomeController> logger)
        {
            Logger = logger;
        }
        public IActionResult Index()
        {
            Logger.LogInformation("Home Controller - Method Index");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            Logger.LogInformation("Home Controller - Method About");
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            Logger.LogInformation("Home Controller - Method Contact");
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
