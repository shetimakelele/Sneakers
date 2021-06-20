
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sneakers.Core.Data.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        public string ShoppingCartSessionID { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set;  }

        public ShoppingCart (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart (IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; // on recupere une session

            var context = service.GetService<AppDbContext>();

            var sessionCart = session.GetString("cartIdSession") ?? Guid.NewGuid().ToString();

            session.SetString("cartIdSession", sessionCart);

            return new ShoppingCart(context) { ShoppingCartSessionID = sessionCart };
  
        }

        // ajouter un produit au panier

        public void AddToCart(Sneaker sneaker, int amount)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.FirstOrDefault(Item => Item.ShoppingCartSessionId == ShoppingCartSessionID && Item.Sneaker.SneakerId == sneaker.SneakerId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartSessionId = ShoppingCartSessionID,
                    Sneaker = sneaker,
                    Amount = 1
                };
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }


       // suprimer un produit du panier
       public int RemoveFromCart(Sneaker sneaker)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Sneaker.SneakerId == sneaker.SneakerId && s.ShoppingCartSessionId == ShoppingCartSessionID); // on verifie si le produit existe dans le panier pour la session

            var localAmount = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartSessionId == ShoppingCartSessionID).Include(s => s.Sneaker).ToList());
            
        }

        public  void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(cart => cart.ShoppingCartSessionId == ShoppingCartSessionID);

                _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

                _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartSessionId == ShoppingCartSessionID).Select(c => c.Sneaker.Price * c.Amount).Sum();
            return total;
        }
    }
}
