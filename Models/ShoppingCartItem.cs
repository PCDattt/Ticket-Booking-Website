﻿using System.ComponentModel.DataAnnotations;

namespace Ticket_Booking_Website.Models
{
	public class ShoppingCartItem
	{
		[Key]
		public int Id { get; set; }
		public Movie Movie { get; set; }
		public int Amount { get; set; }
		public string ShoppingCartId { get; set; }
	}
}
