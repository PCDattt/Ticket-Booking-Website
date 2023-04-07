using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ticket_Booking_Website.Data;
using Ticket_Booking_Website.Data.Services;
using Ticket_Booking_Website.Models;

namespace Ticket_Booking_Website.Controllers
{
    public class CinemasController : Controller
    {
		private readonly ICinemasService _service;
		public CinemasController(ICinemasService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }

        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo, Name, Description")] Cinema cinema)
        {
			if (!ModelState.IsValid)
			{
				await _service.AddAsync(cinema);
				return RedirectToAction(nameof(Index));
			}
			return View(cinema);
		}

        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cinema cinema)
        {
			if (!ModelState.IsValid)
			{
				await _service.UpdateAsync(id, cinema);
				return RedirectToAction(nameof(Index));
			}
			return View(cinema);
		}
        public async Task<IActionResult> Delete(int id)
        {
            var cinema = await _service.GetByIdAsync(id);
            if (cinema == null) return View("NotFound");
            return View(cinema);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinema = await _service.GetByIdAsync(id);
            if (cinema == null) return View("NotFound");

            await _service.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
    }
}
