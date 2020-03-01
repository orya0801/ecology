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
        public BoxesFromAdressController()
        {
            if (BoxesController.Boxes.Count == 0)
            {
                BoxesController.Boxes.Add(new Box { Id = 1, Adress = "Lomonosova st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 2, Adress = "Lomonosova st.", Location = "1300", Owner = "admin", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 3, Adress = "Lomonosova st.", Location = "1400", Owner = "admin", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 4, Adress = "Lomonosova st.", Location = "1500", Owner = "qwerty123", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 5, Adress = "Lomonosova st.", Location = "2000", Owner = "qwerty123", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 6, Adress = "Lomonosova st.", Location = "2100", Owner = "qwerty123", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 7, Adress = "Lomonosova st.", Location = "2300", Owner = "qwerty123", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 8, Adress = "Lomonosova st.", Location = "2400", Owner = "qwerty123", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 9, Adress = "Kronversky st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 10, Adress = "Kronversky st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 11, Adress = "Gastello st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 12, Adress = "Gastello st.", Location = "1200", Owner = "qwerty123", Fullness = 1 });
                BoxesController.Boxes.Add(new Box { Id = 13, Adress = "Lomonosova st.", Location = "1200", Owner = "qwerty123", Fullness = 0 });
            }
        }

        [HttpGet("{adress}")]
        public List<Box>  GetBoxesFromAdress(string adress)
        {
            adress = adress.Replace("[QUOTE]", ".");
            adress = adress.Replace("%20", " ");
            List<Box> boxes = new List<Box>();
            foreach(var box in BoxesController.Boxes)
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
