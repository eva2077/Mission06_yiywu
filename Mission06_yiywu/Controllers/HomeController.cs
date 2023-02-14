using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_yiywu.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_yiywu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieFormContext _movieFormContext {get;set;}   
        //constructor
        public HomeController(ILogger<HomeController> logger, MovieFormContext movieFormContext)
        {
            _logger = logger;
            _movieFormContext = movieFormContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                _movieFormContext.Add(ar);
                _movieFormContext.SaveChanges();
                return View("confirmation", ar);
            }
            else
            {
                return View();
            }

            
           
        }

        public IActionResult MyPodcasts()
        {
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
