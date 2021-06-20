using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sneakers.Core.Data.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppinfCartItemId { get; set; }

        public Sneaker Sneaker { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartSessionId { get; set; }



    }
}
