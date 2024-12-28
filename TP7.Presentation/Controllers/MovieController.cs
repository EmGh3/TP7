using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TP7.Application.ServiceInterfaces;
using TP7.Domain.Models;

namespace TP7.Presentation.Controllers
{

    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IGenreService _genreService;
        private readonly IReviewService _reviewService;
        private readonly IClientService _clientService;
        private readonly IClientMovieService _clientMovieService;
        public MovieController(IMovieService movieService, IGenreService genreService, IReviewService reviewService, IClientService clientService, IClientMovieService clientMovieService)
        {
            _movieService = movieService;
            _genreService = genreService;
            _reviewService = reviewService;
            _clientService = clientService;
            _clientMovieService = clientMovieService;
        }
        public IActionResult Index()
        {
            IEnumerable<Movie> movies = _movieService.GetAllMoviesOrdered();
            return View(movies);
        }
        public IActionResult Create()
        {
            ViewBag.Genres = new SelectList(_genreService.GetAll(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            _movieService.Add(movie);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult MoviesByGenre(int id)
        {
            IEnumerable<Movie>? movies = _movieService.GetMoviesByGenreId(id);
            return View(movies);
        }
        public IActionResult AverageRating(int id)
        {
            Movie movie = _movieService.GetById(id);
            ViewBag.Rating = _reviewService.GetAverage(id);
            return View(movie);
        }
        public ActionResult AddMovieToClient(int movieId)
        {
            ViewBag.Movie = movieId;
            ViewBag.Clients = new SelectList(_clientService.GetAll(), "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMovieToClient(ClientMovie clientMovie)
        {
            if (ModelState.IsValid)
            {
                clientMovie.Id = 0; // Ensure the Id is not set
                _clientMovieService.Add(clientMovie);
                return RedirectToAction("Index", "Movie");
            }
            ViewBag.Clients = new SelectList(_clientService.GetAll(), "Id", "Name");
            return View(clientMovie);
        }

    }
}
