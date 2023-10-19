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
            var trainers = await _context.Trainers
                .Include(t => t.Speciality)
                .ToListAsync();

            var customers = await _context.Customers
                .Include(c => c.Objectives)
                .ToListAsync();

            // Convertissez la liste des clients en une liste de CustomerObjectivesVM
            var customerObjectivesList = customers.Select(customer => new CustomerObjectivesVM
            {
                Customer = customer,
                Objectives = customer.Objectives.ToList(),
            }).ToList();

            var trainerObjectivesVM = new TrainerObjectivesVM
            {
                Trainers = trainers,
                Customers = customerObjectivesList
            };

            return View(trainerObjectivesVM);
        }
    }
}
