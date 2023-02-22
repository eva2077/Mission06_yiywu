using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_yiywu.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Mission06_yiywu.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _movieFormContext {get;set;}   
        //constructor
        public HomeController(MovieFormContext movieFormContext)
        {
            
            _movieFormContext = movieFormContext;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        //Get info from form 
        [HttpGet]
        public IActionResult MovieForm()
        {
            
            ViewBag.Category = _movieFormContext.Category.ToList();
            return View("MovieForm", new ApplicationResponse());

            
        }
        //Post the info on the form to store in database
        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            //if the requirment of the field is met than the user will be redirected to confirmation page
            if (ModelState.IsValid)
            {
                _movieFormContext.Add(ar);
                _movieFormContext.SaveChanges();
                return View("confirmation", ar);
            }
            else
            {
                ViewBag.Category = _movieFormContext.Category.ToList();
                return View();
            }

            
           
        }
        //allow user to view mypodcast page
        public IActionResult MyPodcasts()
        {
            return View();
        }
        // alow users to see the movie list 
        [HttpGet]
        public IActionResult MovieList()
        {
            var applications = _movieFormContext.ApplicationResponse
            .Include(x => x.Category)
            .OrderBy(x => x.Category)
            .ToList();
            return View(applications);
        }

        //Get info to edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //get list of categories possible
            ViewBag.Category = _movieFormContext.Category.ToList();
            //populate with the right movie info based on id
            var application = _movieFormContext.ApplicationResponse.Single(x => x.MovieId == id);
            //Take you to the form 
            return View("MovieForm",application);
            
        }
        //post info of edit
        [HttpPost]
        public IActionResult Edit(ApplicationResponse change)
        {
            _movieFormContext.Update(change);
            _movieFormContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        //Allow user to delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //get information of the movieId that will be deleted based on id
            var application = _movieFormContext.ApplicationResponse.Single(x => x.MovieId == id);
            return View(application);
           
        }
        //Post deleted results 
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar) {

            _movieFormContext.ApplicationResponse.Remove(ar);
            _movieFormContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
