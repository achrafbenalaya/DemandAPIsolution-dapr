using DemandeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemandeClient.Persistance
{
   public interface IDemandeRepository
    {
        Task<IEnumerable<Demandes>> GetListDemandes();
    }
}
