using Microsoft.EntityFrameworkCore;
using Ticket_Booking_Website.Data.Base;
using Ticket_Booking_Website.Models;

namespace Ticket_Booking_Website.Data.Services
{
	public class ActorsService : EntityBaseRepository<Actor>, IActorsService
	{
		private readonly AppDbContext _context;

		public ActorsService(AppDbContext context) : base(context) { }
	}
}
