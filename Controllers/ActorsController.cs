using Microsoft.AspNetCore.Mvc;
using Ticket_Booking_Website.Data;
using Ticket_Booking_Website.Data.Services;

namespace Ticket_Booking_Website.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
