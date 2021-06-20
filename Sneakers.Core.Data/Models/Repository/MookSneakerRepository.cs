using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sneakers.Core.Data.Models.Repository
{
    public class MookSneakerRepository : ISneakerRepository
    {
        private readonly ICategoryRepository _category = new MookCategoryRepository();

        public IEnumerable<Sneaker> GetAllSneakers()
        {
            return new List<Sneaker>()
            {
                new Sneaker{ SneakerId=1 , SneakerName="la Ruben", LongDescription="Bla Bla Bla", ImageUrl="https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", Instock=true, ShortDescription="Bla Bla", Price=99,CategoryId=1, Category=_category.GetCategoryById(1)},
                new Sneaker{ SneakerId=2 , SneakerName="la Ruben", LongDescription="Bla Bla Bla", ImageUrl="https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", Instock=true, ShortDescription="Bla Bla", Price=99,CategoryId=2, Category=_category.GetCategoryById(2)},
                new Sneaker{ SneakerId=3 , SneakerName="la Ruben", LongDescription="Bla Bla Bla", ImageUrl="https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", Instock=true, ShortDescription="Bla Bla", Price=99,CategoryId=1, Category=_category.GetCategoryById(1)},
                new Sneaker{ SneakerId=4 , SneakerName="la Ruben", LongDescription="Bla Bla Bla", ImageUrl="https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", Instock=true, ShortDescription="Bla Bla", Price=99,CategoryId=2, Category=_category.GetCategoryById(2)},
                new Sneaker{ SneakerId=5 , SneakerName="la Ruben", LongDescription="Bla Bla Bla", ImageUrl="https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", Instock=true, ShortDescription="Bla Bla", Price=99,CategoryId=1, Category=_category.GetCategoryById(1)},
                new Sneaker{ SneakerId=6 , SneakerName="la Ruben", LongDescription="Bla Bla Bla", ImageUrl="https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", Instock=true, ShortDescription="Bla Bla", Price=99,CategoryId=3, Category=_category.GetCategoryById(3)},
            };
        }

        public Sneaker GetSneakerById(int id)
        {
            return GetAllSneakers().FirstOrDefault(s => s.SneakerId == id);
        }
    }
}
