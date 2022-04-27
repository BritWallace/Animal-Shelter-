using Microsoft.EntityFrameworkCore;

namespace Animal.Models
{
public class AnimalContext : DbContext
{
    public AnimalContext(DbContextOptions<AnimalContext> options)
        : base(options)
    {
    }

            protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Animal>()
                .HasData(
                    new Animal { AnimalId = 1, Name = "Frenchy", Species = "Cat", Breed = "Unknown", Age = 5, Gender = "Female"},
                    new Animal { AnimalId = 2, Name = "Pickels", Species= "Cat", Breed = "Persian", Age = 4, Gender = "Female" },
                    new Animal { AnimalId = 3, Name = "Spot", Species = "Dog", Breed= "Husky", Age = 3, Gender = "Female"},
                    new Animal { AnimalId = 4, Name = "Bisque", Species= "Dog", Breed = "Great Dane", Age = 1, Gender = "Male"},
                    new Animal { AnimalId = 5, Name = "Chicago", Species = "Dog", Breed = "German Shepherd", Age = 2, Gender = "Male"},
                    new Animal { AnimalId = 6, Name = "Sammy", Species = "Cat", Breed = "Siamese", Age = 5, Gender = "Male"},
                    new Animal { AnimalId = 7, Name = "Baby", Species = "Dog", Breed = "Bulldog", Age = 9, Gender = "Female"},
                    new Animal { AnimalId = 8, Name = "Rufus", Species = "Dog", Breed = "Beagle", Age = 6, Gender = "Male"},
                    new Animal { AnimalId = 9, Name = "Doug", Species = "Cat", Breed = "Unknown", Age = 10, Gender = "Male"},
                    new Animal { AnimalId = 10, Name = "Lucy", Species = "Dog", Breed = "Mixed", Age = 1, Gender = "Female"}
                );
      }

    public DbSet<Animal > Animals { get; set; }
  }
}
