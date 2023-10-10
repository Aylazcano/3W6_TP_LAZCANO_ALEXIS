using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JuliePro.Models;
using JuliePro.ViewModels;

namespace JuliePro.Controllers
{
    public class ObjectivesController : Controller
    {
        private readonly JulieProDbContext _context;

        public ObjectivesController(JulieProDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> AllObjectives()
        {
            // Récupérez les données nécessaires depuis la base de données
            var trainersWithCustomers = await _context.Trainers
                .Include(t => t.Speciality)
                .Include(t => t.Customers)
                    .ThenInclude(c => c.Objectives)
                .ToListAsync();

            // Préparez les données pour le ViewModel TrainerObjectivesVM
            var trainerObjectivesVM = trainersWithCustomers.Select(trainer => new TrainerObjectivesVM
            {
                Customers = trainer.Customers.Select(customer => new CustomerObjectivesVM
                {
                    Objectives = customer.Objectives
                })
            });

            return View(trainerObjectivesVM);
        }
    }
}
