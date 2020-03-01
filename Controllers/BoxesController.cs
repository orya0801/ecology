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
        

    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<Box>>> Get()
    //    {
    //        return await db.Boxes.ToListAsync();
    //    }

    //    // GET api/users/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<Box>> Get(int id)
    //    {
    //        Box user = await db.Boxes.FirstOrDefaultAsync(x => x.Id == id);
    //        if (user == null)
    //            return NotFound();
    //        return new ObjectResult(user);
    //    }

    //    // POST api/users
    //    [HttpPost]
    //    public async Task<ActionResult<User>> Post(Box user)
    //    {
    //        if (user == null)
    //        {
    //            return BadRequest();
    //        }

    //        db.Boxes.Add(user);
    //        await db.SaveChangesAsync();
    //        return Ok(user);
    //    }

    //    // PUT api/users/
    //    [HttpPut]
    //    public async Task<ActionResult<Box>> Put(Box box)
    //    {
    //        if (box == null)
    //        {
    //            return BadRequest();
    //        }
    //        if (!db.Boxes.Any(x => x.Id == box.Id))
    //        {
    //            return NotFound();
    //        }

    //        db.Update(box);
    //        await db.SaveChangesAsync();
    //        return Ok(box);
    //    }


    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<Box>> Delete(int id)
    //    {
    //        Box box = db.Boxes.FirstOrDefault(x => x.Id == id);
    //        if (box == null)
    //        {
    //            return NotFound();
    //        }
    //        db.Boxes.Remove(box);
    //        await db.SaveChangesAsync();
    //        return Ok(box);
    //    }
    }
}