using System;
using System.Collections.Generic;
using System.Text;

namespace Sneakers.Core.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public List<Sneaker> Sneakers { get; set; }
    }
}
