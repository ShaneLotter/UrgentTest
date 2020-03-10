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
        private IErrorRepository errorRepository;
        public HomeController(IBillMatRepository repo, IErrorRepository errorRepo)
        {
            repository = repo;
            errorRepository = errorRepo;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        
        [HttpPost]
        public ViewResult Submit(ShapesViewModel shapes)
        {
            BillofMaterial billofMaterial = new BillofMaterial();
            try
            {                
                if (ModelState.IsValid)
                {
                    try
                    {
                        billofMaterial = repository.GenerateBill(shapes);
                    }
                    catch (Exception ex)
                    {
                        errorRepository.LogError(ex);
                        billofMaterial = repository.ThrowAbort();
                    }
                }
                else
                {
                    billofMaterial = repository.ThrowAbort();
                }
            }
            catch (Exception ex)
            {
                errorRepository.LogError(ex);
            }
            

            return View(billofMaterial);
        }
    }
}