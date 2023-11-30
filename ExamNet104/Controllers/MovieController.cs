using ExamNet104.Models;
using ExamNet104.Service;
using ExamNet104.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ExamNet104.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieSV _movieSV;
        public MovieController(IMovieSV movieSV)
        {
            _movieSV = movieSV;
        }

        [HttpGet]
        public async Task< IActionResult> Index()
        {
            return View( await _movieSV.GetALl());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(MovieVM movie)
        {
           _movieSV.Add(movie);
            return RedirectToAction("Index");
        }
    }
}
