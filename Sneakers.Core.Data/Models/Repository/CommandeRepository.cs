using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sneakers.Core.Data.Models.Repository
{
    public class CommandeRepository : ICommandeRepository
    {
        private readonly AppDbContext _appDbContext;

        private readonly ShoppingCart _shoppingCart;

        public CommandeRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateCommande(Commande commande)
        {
            // on recupere panier puis on cree une liste 
            commande.DateCommande = DateTime.Now;
            var items = _shoppingCart.GetShoppingCartItems(); 
            commande.CommandeTotal = _shoppingCart.GetShoppingCartTotal(); 
            commande.CommandeDetails = new List<CommandeDetail>();
            foreach (var item in items)
            {
                var commandeDetail = new CommandeDetail
                {
                    SneakerId = item.Sneaker.SneakerId,
                    Amount = item.Amount,
                    Prix = item.Sneaker.Price

                };

                commande.CommandeDetails.Add(commandeDetail);

            }
            _appDbContext.Commandes.Add(commande);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Commande> GetAllCommandes()
        {
            return _appDbContext.Commandes;
        }

        public Commande GetComandeById(int id)
        {
            return _appDbContext.Commandes.FirstOrDefault(com => com.CommandeId == id);
        }
    }
}
