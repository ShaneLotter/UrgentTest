using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrgentTest.Models;
using UrgentTest.ViewModels;

namespace UrgentTest.Controllers
{
    public class HomeController : Controller
    {
        private IBillMatRepository repository;
        public HomeController(IBillMatRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ViewResult Submit(ShapesViewModel shapes)
        {
            BillofMaterial billofMaterial = new BillofMaterial();
            if (ModelState.IsValid)
            {
                billofMaterial = repository.GenerateBill(shapes);
            }
            else
            {
                billofMaterial = repository.ThrowAbort();
            }

            return View(billofMaterial);
        }
    }
}