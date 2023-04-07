using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ticket_Booking_Website.Data;
using Ticket_Booking_Website.Data.Services;

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
    }
}
