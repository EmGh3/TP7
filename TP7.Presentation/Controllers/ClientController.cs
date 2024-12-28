using Microsoft.AspNetCore.Mvc;
using TP7.Application.ServiceInterfaces;
using TP7.Domain.Models;

namespace TP7.Presentation.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IClientMovieService _clientMovieService;
        public ClientController(IClientService clientService, IClientMovieService clientMovieService)
        {
            _clientService = clientService;
            _clientMovieService = clientMovieService;
        }
        public ActionResult Index() {
            return View(_clientService.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client client)
        {
            _clientService.Add(client);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Favourites(int id)
        {
          return View(_clientMovieService.GetMoviesByClientId(id));
        }
    }
}
