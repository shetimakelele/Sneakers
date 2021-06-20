using Microsoft.AspNetCore.Mvc;
using Sneakers.Core.Data.Models.Repository;
using Sneakers.Core.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneakers.Controllers
{
    public class SneakerController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;
        private readonly ICategoryRepository _categoryRepository;


        public SneakerController(ISneakerRepository sneakerRepository, ICategoryRepository categoryRepository)
        {
            _sneakerRepository = sneakerRepository;
            _categoryRepository = categoryRepository; 
        }

        public IActionResult List()
        {
            var sneakerListViewModel = new SneakerListViewModel();
            sneakerListViewModel.Sneakers = _sneakerRepository.GetAllSneakers();
            return View(sneakerListViewModel);
        }

        public IActionResult Details(int idSneaker)
        {
            var sneaker = _sneakerRepository.GetSneakerById(idSneaker);
            if (sneaker == null)
                return NotFound();
            return View(sneaker);
        }


    }
}
