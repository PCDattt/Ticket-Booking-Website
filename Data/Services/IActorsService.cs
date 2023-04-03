﻿using Ticket_Booking_Website.Models;

namespace Ticket_Booking_Website.Data.Services
{
	public interface IActorsService
	{
		IEnumerable<Actor> GetAll();
		Actor GetById(int id);
		void Add(Actor actor);
		Actor Update(int id, Actor actor);
		void Delete(int id);
	}
}
