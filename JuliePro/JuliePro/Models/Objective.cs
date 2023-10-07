using JuliePro.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Objective
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 5)]
        public string Name { get; set; }

        [Range(2,10)]
        public double LostWeightKg { get; set; }

        [Range(2, 45)]
        public double DistanceKm { get; set; }

        public DateTime? AchievedDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        // Propriété de navigation
        public Customer Customer { get; set; }
    }
}
