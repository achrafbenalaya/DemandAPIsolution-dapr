using DemandAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandesController : ControllerBase
    {
        private List<Demandes> thedemandelist = new List<Demandes>
        {

            new Demandes {ID=Guid.NewGuid(),Name="Demande 1"},
            new Demandes {ID=Guid.NewGuid(),Name="Demande 2"},
            new Demandes {ID=Guid.NewGuid(),Name="Demande 3"}
        };

        private readonly ILogger<DemandesController> _logger;
        public DemandesController(ILogger<DemandesController> logger)
        {
            _logger = logger;

        }

        [HttpGet]
        public IEnumerable<Demandes> GetDemandes()
        {
            return thedemandelist;
        }

    }
}
