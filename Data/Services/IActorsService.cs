using Ticket_Booking_Website.Models;

namespace Ticket_Booking_Website.Data.Services
{
	public interface IActorsService
	{
		Task<IEnumerable<Actor>> GetAllAsync();
		Task<Actor> GetByIdAsync(int id);
		Task AddAsync(Actor actor);
		Actor Update(int id, Actor actor);
		void Delete(int id);
	}
}
