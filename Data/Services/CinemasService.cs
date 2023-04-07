using Microsoft.EntityFrameworkCore;
using Ticket_Booking_Website.Data.Base;
using Ticket_Booking_Website.Models;

namespace Ticket_Booking_Website.Data.Services
{
	public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
	{
		private readonly AppDbContext _context;
		public CinemasService(AppDbContext context) : base(context){}
    }
}
