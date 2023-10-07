using JuliePro.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 4)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 4)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        [Range(100,400)]
        public double StartWeight { get; set; }

        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }

        // Propriété de navigation
        public ICollection<Objective>? Objectives { get; set; }
        public Trainer? Trainer { get; set; }
    }
}
