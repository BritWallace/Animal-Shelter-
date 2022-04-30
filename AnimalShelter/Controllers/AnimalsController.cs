using Pets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Pets.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalContext _db;

    public AnimalsController(AnimalContext db)
    {
      _db = db;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string name, string species, string breed, int minimumAge, int maximumAge, string gender)
    {
      var query = _db.Animals.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      } 
      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }
      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }
      if (minimumAge > 0)
      {
        query = query.Where(entry => entry.Age >= minimumAge);
      }
      if (maximumAge > 0)
      {
        query = query.Where(entry => entry.Age >= maximumAge);
      }
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      return await query.ToListAsync();
    }
    

    }
    
  }