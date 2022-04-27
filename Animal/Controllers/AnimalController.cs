using Animal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Animal.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalController : ControllerBase
  {
    private readonly AnimalContext _db;

    public AnimalController(AnimalContext db)
    {
      _db = db;
    }
  }
}    