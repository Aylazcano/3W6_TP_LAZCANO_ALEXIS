using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Speciality
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Le champ Name doit avoir entre 5 et 20 caractères.")]
        public string Name { get; set; }

        // Liaison 1..1
        public Trainer Trainer { get; set; }
    }
}
