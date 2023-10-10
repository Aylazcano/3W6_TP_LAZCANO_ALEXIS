using JuliePro.Models;

namespace JuliePro.ViewModels
{
    public class CustomerObjectivesVM
    {
        public int CustomerId { get; set; }
        public string CustomerFirtName { get; set; }
        public string CustomerLastName { get; set; }
        public int CompletedObjectives { get; set; }
        public int IncompleteObjectives { get; set; }
        public IEnumerable<Objective> Objectives { get; set; }
    }
}
