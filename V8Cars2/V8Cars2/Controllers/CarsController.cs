using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using V8Cars2.Models.ViewModels;
using V8Cars2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace V8Cars2.Controllers
{
    public class CarsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(DataManager.ListCars());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarsCreateVM carToCreate)
        {
            if (!ModelState.IsValid)
            return View(carToCreate);

            DataManager.AddCar(carToCreate);
            return RedirectToAction(nameof(Index));

        }
    }
}
