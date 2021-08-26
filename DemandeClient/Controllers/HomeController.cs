using DemandeClient.Models;
using DemandeClient.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemandeClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDemandeRepository _IDemandeRepository;
        public HomeController(ILogger<HomeController> logger, IDemandeRepository IDemandeRepository)
        {
            _logger = logger;
            _IDemandeRepository = IDemandeRepository;
        }

        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Starting...");
            var Data = await _IDemandeRepository.GetListDemandes();
            _logger.LogInformation("Done...");
            return View(Data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
