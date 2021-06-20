using Microsoft.AspNetCore.Mvc;
using Sneakers.Core.Data.Models;
using Sneakers.Core.Data.Models.Repository;
using Sneakers.Core.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneakers.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController (ISneakerRepository sneakerRepository, ShoppingCart shoppingCart)
        {
            _sneakerRepository = sneakerRepository;
            _shoppingCart = shoppingCart;
        }
        // afffiche recap commande
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel();
            shoppingCartViewModel.ShoppingCart = _shoppingCart;
            shoppingCartViewModel.ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal();

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int idSneaker)
        {
            var sneaker = _sneakerRepository.GetSneakerById(idSneaker);
            if (sneaker!= null)
            {
                _shoppingCart.AddToCart(sneaker, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int idSneaker)
        {
            var sneaker = _sneakerRepository.GetSneakerById(idSneaker);
            if (sneaker != null)
            {
                _shoppingCart.RemoveFromCart(sneaker);
            }
            return RedirectToAction("Index");
        }

    }
}
