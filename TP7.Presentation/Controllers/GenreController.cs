using Microsoft.AspNetCore.Mvc;
using TP7.Application.ServiceInterfaces;
using TP7.Domain.Models;

namespace TP7.Presentation.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        public IActionResult Index()
        {
            IEnumerable<Genre> genres = _genreService.GetAll();
            return View(genres);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Genre genre)
        {
            _genreService.Add(genre);
            return RedirectToAction(nameof(Index));
        }
    }
}