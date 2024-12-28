using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TP7.Application.ServiceInterfaces;
using TP7.Application.Services;
using TP7.Domain.Models;

namespace TP7.Presentation.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;
        private readonly IMovieService _movieService;
        private readonly IClientService _clientService;
        public ReviewController(IReviewService reviewService, IMovieService movieService, IClientService clientService)
        {
            _reviewService = reviewService;
            _movieService = movieService;
            _clientService = clientService;
        }
        public ActionResult Create(int movieId)
        {
            ViewBag.Movie = movieId;
            ViewBag.Clients = new SelectList(_clientService.GetAll(), "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Review review)
        {
            if (ModelState.IsValid)
            {
                _reviewService.Add(review);
                return RedirectToAction("Index", "Movie");
            }
            ViewBag.Clients = new SelectList(_clientService.GetAll(), "Id", "Name");
            return View(review);
        }

    }
}
