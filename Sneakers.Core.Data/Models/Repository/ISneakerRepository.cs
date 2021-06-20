using System;
using System.Collections.Generic;
using System.Text;

namespace Sneakers.Core.Data.Models.Repository
{
    public interface ISneakerRepository
    {
        IEnumerable<Sneaker> GetAllSneakers();

        Sneaker GetSneakerById(int id);
    }
}
// creer ici une methode pour les sneakers preferées pour home page