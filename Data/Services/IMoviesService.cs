using Ticket_Booking_Website.Data.Base;
using Ticket_Booking_Website.Data.ViewModels;
using Ticket_Booking_Website.Models;

namespace Ticket_Booking_Website.Data.Services
{
	public interface IMoviesService : IEntityBaseRepository<Movie>
	{
		Task<Movie> GetMovieByIdAsync(int id);
		Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
		Task AddNewMovieAsync(NewMovieVM data);
		Task UpdateMovieAsync(NewMovieVM data);

	}
}
