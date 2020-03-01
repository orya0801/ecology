using System;
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
    public class BoxesFromAdressController : Controller
    {

        [HttpGet("{adress}")]
        public async Task<List<Box>>  GetBoxesFromAdress(string adress)
        {
            adress = adress.Replace("[QUOTE]", ".");
            adress = adress.Replace("%20", " ");
            List<Box> boxes = new List<Box>();
            await foreach(var box in db.Boxes)
            {
                if (box.Adress == adress)
                {
                    boxes.Add(box);
                }
            }
            

            return boxes;
        }
    }
}
