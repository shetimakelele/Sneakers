using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sneakers.Core.Data.Models.Repository
{
    public class SneakerRepository : ISneakerRepository
    {
        private readonly AppDbContext _appDbContext;

        // constructeur

        public SneakerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Sneaker> GetAllSneakers()
        {
            return _appDbContext.Sneakers.Include(c => c.Category);
        }

        public Sneaker GetSneakerById(int id)
        {
            return _appDbContext.Sneakers.FirstOrDefault(s => s.SneakerId == id);
        }
    }
}
