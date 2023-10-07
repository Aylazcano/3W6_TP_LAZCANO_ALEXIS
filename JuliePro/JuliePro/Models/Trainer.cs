using JuliePro.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Trainer
{
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

    [StringLength(40)]
    public string Photo { get; set; }

    // Liaison 1..1
    [ForeignKey("Speciality")]
    public int SpecialityId { get; set; }

    // Propriétés de navigation
    public Speciality Speciality { get; set; }
}
