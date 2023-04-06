using Ticket_Booking_Website.Data.Base;
using Ticket_Booking_Website.Models;

namespace Ticket_Booking_Website.Data.Services
{
	public class ProducersService:EntityBaseRepository<Producer>, IProducersService
	{
		public ProducersService(AppDbContext context) : base(context) { }
	}
}
