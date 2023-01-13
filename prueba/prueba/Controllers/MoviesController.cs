using prueba.Models;
using prueba.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prueba.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {

            var viewModel = new MovieViewModel
            {
                Movies = new List<Movie>
                {
                    new Movie { Name = "Shrek!" },
                    new Movie { Name = "Wall-e" }
                }
            };

            return View(viewModel);
        }
    }
}