using System;
using System.Collections.Generic;
using System.Text;

namespace Sneakers.Core.Data.Models.Repository
{
    public interface ICommandeRepository
    {
        void CreateCommande(Commande commande);

        IEnumerable<Commande> GetAllCommandes();

        Commande GetComandeById(int id);
    }
}
