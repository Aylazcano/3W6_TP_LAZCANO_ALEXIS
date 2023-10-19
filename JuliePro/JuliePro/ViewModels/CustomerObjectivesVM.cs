using JuliePro.Models;

namespace JuliePro.ViewModels
{
    public class CustomerObjectivesVM
    {
        public Customer Customer { get; set; }
        public IEnumerable<Objective> Objectives { get; set; }
    }
}
