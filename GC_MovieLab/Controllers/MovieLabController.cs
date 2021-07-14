using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GC_MovieLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace GC_MovieLab.Controllers
{
    public class MovieLabController : Controller
    {
        private readonly MovieLabContext _context;


        public MovieLabController(MovieLabContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        public IActionResult Add()
        {
            Movie newMovie = new Movie();
            return View(newMovie);
        }

        public IActionResult Result(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return View(movie);
        }

        public IActionResult Delete(int id)
        {
            Movie movieToDelete = new Movie() { Id = id };
            _context.Entry(movieToDelete).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
            return View(movieToDelete);
        }

        public IActionResult Edit(int id)
        {
            var movieToEdit = _context.Movies.FirstOrDefault(x => x.Id == id);
            return View(movieToEdit);
        }

        public IActionResult SaveChanges(Movie movie)
        {
            var movieToEdit = _context.Movies.FirstOrDefault(x => x.Id == movie.Id);
            movieToEdit.Title = movie.Title;
            movieToEdit.Genre = movie.Genre;
            movieToEdit.Runtime = movie.Runtime;
            _context.SaveChanges();
            return View("EditResult", movie);
        }
    }
}
