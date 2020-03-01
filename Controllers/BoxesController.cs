using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoxesController : ControllerBase
    {
        BoxesContext db;
        public BoxesController(BoxesContext context)
        {
            db = context;
            if (!db.Boxes.Any())
            {
                db.Boxes.Add(new Box { Id = 1, Adress = "Кронверский проспект", Fullness = 1, Location = "Кабинет 316", Owner="zero"});
                /*
                db.Containers.Add(new Container { Id = 2, Adress = "Кронверский проспект", Fullness = 1, Location = "Кабинет 216", Owner = "admin" });
                db.Containers.Add(new Container { Id = 3, Adress = "Кронверский проспект", Fullness = 1, Location = "Кабинет 116", Owner = "zero" });
                db.Containers.Add(new Container { Id = 4, Adress = "Кронверский проспект", Fullness = 1, Location = "Кабинет 318", Owner = "qwerty" });
                db.Containers.Add(new Container { Id = 5, Adress = "Кронверский проспект", Fullness = 1, Location = "Кабинет 320", Owner = "zero" });
                db.Containers.Add(new Container { Id = 6, Adress = "Кронверский проспект", Fullness = 1, Location = "Кабинет 288", Owner = "qwerty" });
                db.Containers.Add(new Container { Id = 7, Adress = "Кронверский проспект", Fullness = 1, Location = "Кабинет 101", Owner = "zero" });
                db.Containers.Add(new Container { Id = 8, Adress = "Кронверский проспект", Fullness = 1, Location = "Столовая", Owner = "zero" });
                db.Containers.Add(new Container { Id = 9, Adress = "Улица Ломоносова", Fullness = 0, Location = "Кабинет 316", Owner = "admin" });
                db.Containers.Add(new Container { Id = 10, Adress = "Улица Гастелло", Fullness = 0, Location = "Кабинет 316", Owner = "zero" });
                */
                db.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Box>>> Get()
        {
            return await db.Boxes.ToListAsync();
        }

        // GET api/containers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Box>> Get(int id)
        {
            Box user = await db.Boxes.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
                return NotFound();
            return new ObjectResult(user);
        }

    }
}