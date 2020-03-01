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
        public static List<Box> Boxes = new List<Box>();

        public BoxesController()
        {
            if (BoxesController.Boxes.Count == 0)
            {
                Boxes.Add(new Box { Id = 1, Adress = "Lomonosova st.", Location = "1200",  Owner = "qwerty123", Fullness = 1 });
                Boxes.Add(new Box { Id = 2, Adress = "Lomonosova st.", Location = "1300", Owner = "admin", Fullness = 1 });
                Boxes.Add(new Box { Id = 3, Adress = "Lomonosova st.", Location= "1400", Owner = "admin", Fullness = 1 });
                Boxes.Add(new Box { Id = 4, Adress = "Lomonosova st.", Location = "1500", Owner = "qwerty123", Fullness = 1 });
                Boxes.Add(new Box { Id = 5, Adress = "Lomonosova st.", Location = "2000", Owner = "qwerty123", Fullness = 1 });
                Boxes.Add(new Box { Id = 6, Adress = "Lomonosova st.", Location = "2100", Owner = "qwerty123", Fullness = 1 });
                Boxes.Add(new Box { Id = 7, Adress = "Lomonosova st.", Location = "2300", Owner = "qwerty123", Fullness = 1 });
                Boxes.Add(new Box { Id = 8, Adress = "Lomonosova st.", Location = "2400", Owner = "qwerty123", Fullness = 1 });
                Boxes.Add(new Box { Id = 9, Adress = "Kronversky st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                Boxes.Add(new Box { Id = 10, Adress = "Kronversky st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                Boxes.Add(new Box { Id = 11, Adress = "Gastello st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                Boxes.Add(new Box { Id = 12, Adress = "Gastello st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                Boxes.Add(new Box { Id = 13, Adress = "Lomonosova st.", Location = "1200", Owner = "qwerty123", Fullness = 0 });
            }
        }

        [HttpGet]
        public ActionResult<List<Box>> Get()
        {
            return Boxes;
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<Box> Get(int id)
        {
            Box currbox = new Box();
            foreach (var box in Boxes)
            {
                if (box.Id == id) currbox = box;
            }
            if (currbox == null)
                return NotFound();
            return new ObjectResult(currbox);
        }

        // POST api/users
        [HttpPost]
        public ActionResult<User> Post(Box user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            Boxes.Add(user);
            return Ok(user);
        }

        // PUT api/users/
        [HttpPut]
        public ActionResult<Box> Put(Box box)
        {
            if (box == null)
            {
                return BadRequest();
            }
            if (!Boxes.Any(x => x.Id == box.Id))
            {
                return NotFound();
            }

            return Ok(box);
        }


        [HttpDelete("{id}")]
        public ActionResult<Box> Delete(int id)
        {
            Box box = Boxes.FirstOrDefault(x => x.Id == id);
            if (box == null)
            {
                return NotFound();
            }
            Boxes.Remove(box);
            return Ok(box);
        }
    }
}