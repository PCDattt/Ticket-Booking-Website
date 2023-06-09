﻿using Microsoft.AspNetCore.Mvc;
using Ticket_Booking_Website.Data.Cart;
using Ticket_Booking_Website.Data.Services;
using Ticket_Booking_Website.Data.ViewModels;

namespace Ticket_Booking_Website.Controllers
{
	public class OrdersController : Controller
	{
		private readonly IMoviesService _moviesService;
		private readonly ShoppingCart _shoppingCart;
        public OrdersController(IMoviesService moviesService, ShoppingCart shoppingCart)
        {
			_moviesService = moviesService;
			_shoppingCart = shoppingCart;
        }

        public IActionResult ShoppingCart()
		{
			var items = _shoppingCart.GetShoppingCartItems();
			_shoppingCart.ShoppingCartItems = items;
			var response = new ShoppingCartVM()
			{
				ShoppingCart = _shoppingCart,
				ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
			};
			return View(response);
		}
	}
}
