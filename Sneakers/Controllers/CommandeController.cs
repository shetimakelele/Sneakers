using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sneakers.Core.Data.Models;
using Sneakers.Core.Data.Models.Repository;

namespace PharmacieDelaCharmeuse.Controllers
{
    public class CommandeController : Controller
    {
        private readonly ICommandeRepository _commandeRepository;
        private readonly ShoppingCart _shoppingCart;

        public CommandeController (ICommandeRepository commandeRepository, ShoppingCart shoppingCart)
        {
            _commandeRepository = commandeRepository;
            _shoppingCart       = shoppingCart;
        }

        [HttpGet]
        public IActionResult CreateCommande()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCommande(Commande commande)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Votre panier es vide, Remplissez en premier lieu"); // si panier vide
            }
            if (ModelState.IsValid) // teste si formulaire valide, on cree une commande
            {
                _commandeRepository.CreateCommande(commande);
                _shoppingCart.ClearCart();
                RedirectToAction("ConfirmeCommande");

            }
            return View(commande);
        }
        public IActionResult ConfirmeCommande()
        {
            return View();
        }

        public IActionResult ListCommande()
        {
            var commandeList = _commandeRepository.GetAllCommandes();

            return View(commandeList);
        }
    }
}
