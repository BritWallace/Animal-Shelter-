using System.ComponentModel.DataAnnotations;

namespace Pets.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    [Range(0, 20, ErrorMessage = "Age must be between 0 and 20.")]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
    
  }
}