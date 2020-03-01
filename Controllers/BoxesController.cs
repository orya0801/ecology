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
                db.Boxes.Add(new Box { Id = 1, Adress = "Lomonosova st.", Location = "1200",  Owner = "qwerty123", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 2, Adress = "Lomonosova st.", Location = "1300", Owner = "admin", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 3, Adress = "Lomonosova st.", Location= "1400", Owner = "admin", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 4, Adress = "Lomonosova st.", Location = "1500", Owner = "qwerty123", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 5, Adress = "Lomonosova st.", Location = "2000", Owner = "qwerty123", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 6, Adress = "Lomonosova st.", Location = "2100", Owner = "qwerty123", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 7, Adress = "Lomonosova st.", Location = "2300", Owner = "qwerty123", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 8, Adress = "Lomonosova st.", Location = "2400", Owner = "qwerty123", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 9, Adress = "Kronversky st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 10, Adress = "Kronversky st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 11, Adress = "Gastello st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 12, Adress = "Gastello st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                db.Boxes.Add(new Box { Id = 13, Adress = "Lomonosova st.", Location = "1200", Owner = "qwerty123", Fullness = 0 });

                db.Database.OpenConnection();

                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Boxes ON");
                db.SaveChanges();
                db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Boxes OFF");

                db.Database.CloseConnection();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Box>>> Get()
        {
            return await db.Boxes.ToListAsync();
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Box>> Get(int id)
        {
            Box user = await db.Boxes.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
                return NotFound();
            return new ObjectResult(user);
        }

        // POST api/users
        [HttpPost]
        public async Task<ActionResult<User>> Post(Box user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            db.Boxes.Add(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }

        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<Box>> Put(Box box)
        {
            if (box == null)
            {
                return BadRequest();
            }
            if (!db.Boxes.Any(x => x.Id == box.Id))
            {
                return NotFound();
            }

            db.Update(box);
            await db.SaveChangesAsync();
            return Ok(box);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Box>> Delete(int id)
        {
            Box box = db.Boxes.FirstOrDefault(x => x.Id == id);
            if (box == null)
            {
                return NotFound();
            }
            db.Boxes.Remove(box);
            await db.SaveChangesAsync();
            return Ok(box);
        }
    }
}