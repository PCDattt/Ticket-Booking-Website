using Microsoft.EntityFrameworkCore;
using Ticket_Booking_Website.Data.Base;
using Ticket_Booking_Website.Data.ViewModels;
using Ticket_Booking_Website.Models;

namespace Ticket_Booking_Website.Data.Services
{
	public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
	{
		private readonly AppDbContext _context;
		public MoviesService(AppDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task AddNewMovieAsync(NewMovieVM data)
		{
			var newMovie = new Movie()
			{
				Name = data.Name,
				Description = data.Description,
				Price = data.Price,
				ImageURL = data.ImageURL,
				CinemaId = data.CinemaId,
				StartDate = data.StartDate,
				EndDate = data.EndDate,
				MovieCategory = data.MovieCategory,
				ProducerId = data.ProducerId
			};
			await _context.Movies.AddAsync(newMovie);
			await _context.SaveChangesAsync();
			
			foreach (var actorId in data.ActorIds)
			{
				var newActorMovie = new Actor_Movie()
				{
					MovieId = newMovie.Id,
					ActorId = actorId
				};
				await _context.Actors_Movies.AddAsync(newActorMovie);
			}
			await _context.SaveChangesAsync();
		}

		public async Task<Movie> GetMovieByIdAsync(int id)
		{
			var movieDetails = await _context.Movies
				.Include(c => c.Cinema)
				.Include(p => p.Producer)
				.Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
				.FirstOrDefaultAsync(n => n.Id == id);

			return movieDetails;
		}

		public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
		{
			var response = new NewMovieDropdownsVM();
			response.Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync();
			response.Cinemas = await _context.Cinemas.OrderBy(n => n.Name).ToListAsync();
			response.Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync();

			return response;
		}
	}
}
