using Ticket_Booking_Website.Data.Base;
using Ticket_Booking_Website.Models;

namespace Ticket_Booking_Website.Data.Services
{
	public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
	{
		public MoviesService(AppDbContext context) : base(context){}
	}
}
