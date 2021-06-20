using Sneakers.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sneakers.Core.Data.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set;  }

        public decimal ShoppingCartTotal { get; set; }
    }
}
