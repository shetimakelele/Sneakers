using System;
using System.Collections.Generic;
using System.Text;

namespace Sneakers.Core.Data.Models.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();

        Category GetCategoryById(int id);
    }
}
