using DemandeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace DemandeClient.Persistance
{
    public class DemandeRepository : IDemandeRepository
    {
     
        private readonly HttpClient _httpClient;

        public DemandeRepository(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<Demandes>> GetListDemandes()
        {
            return await _httpClient.
                  GetFromJsonAsync<IEnumerable<Demandes>>("/api/demandes");
           
        }


    }
}
