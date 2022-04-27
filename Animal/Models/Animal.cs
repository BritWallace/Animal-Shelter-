using System.ComponentModel.DataAnnotations;

namespace Animal.Models
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
    public string Age { get; set; }
    public string Gender { get; set; }
    
  }
}