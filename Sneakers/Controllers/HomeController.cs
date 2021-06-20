using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sneakers.Core.Data.Models.Repository;
using Sneakers.Core.Data.ViewModels;
using Sneakers.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sneakers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;

        public HomeController(ISneakerRepository sneakerRepository)
        {
            _sneakerRepository = sneakerRepository;
        }


        public IActionResult Index()
        {
            var listSneaker = new SneakerListViewModel();
            listSneaker.Sneakers = _sneakerRepository.GetAllSneakers().Take(3);
            return View(listSneaker);
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
