using Ticket_Booking_Website.Controllers;
using Ticket_Booking_Website.Models;

namespace Ticket_Booking_Website.Data.ViewModels
{
	public class NewMovieDropdownsVM
	{
		public NewMovieDropdownsVM()
		{
			Producers = new List<Producer>();
			Actors = new List<Actor>();
			Cinemas = new List<Cinema>();
		}
		public List<Producer> Producers { get; set; }
		public List<Actor> Actors { get; set; }
		public List<Cinema> Cinemas { get; set; }
	}
}
