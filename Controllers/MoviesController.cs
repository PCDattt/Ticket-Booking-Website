using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ticket_Booking_Website.Data;
using Ticket_Booking_Website.Data.Services;
using Ticket_Booking_Website.Models;

namespace Ticket_Booking_Website.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;
        public MoviesController(IMoviesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
			var allMovies = await _service.GetAllAsync(n => n.Cinema);
			return View(allMovies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _service.GetMovieByIdAsync(id);
            return View(movieDetails);
        }

        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _service.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
			ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
			ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

			return View();
		}

        [HttpPost]
		public async Task<IActionResult> Create(NewMovieVM movie)
        {
            await _service.AddNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }

	}
}
