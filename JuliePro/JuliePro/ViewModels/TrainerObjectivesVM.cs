namespace JuliePro.ViewModels
{
    public class TrainerObjectivesVM
    {
        public int TrainerId { get; set; }
        public string TrainerFirtName { get; set; }
        public string TrainerLastName { get; set; }
        public string Speciality { get; set; }

        public IEnumerable<CustomerObjectivesVM> Customers { get; set; }
    }
}
