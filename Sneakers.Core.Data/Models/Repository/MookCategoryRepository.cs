using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sneakers.Core.Data.Models.Repository
{
    public class MookCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories()
        {
            return new List<Category>()
            {
                new Category { CategoryId=1 , CategoryName="Rebecca" ,Description="femmes"},
                new Category { CategoryId=2 , CategoryName="Elijaah" ,Description="enfants"},
                new Category { CategoryId=3 , CategoryName="Cindy" ,Description="femmes"},
                new Category { CategoryId=4 , CategoryName="Sheti" ,Description="hommes"},
            };
        }

        public Category GetCategoryById(int id)
        {
            return GetAllCategories().FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
