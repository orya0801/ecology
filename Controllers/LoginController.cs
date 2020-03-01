using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        UsersContext db;
        public LoginController(UsersContext context)
        {
            db = context;
        }

        [HttpPost]
        public int Login([FromHeader] string login, [FromHeader]string password)
        {
            if (db.Users.Find(login) != null)
            {
                User user = db.Users.Find(login);
                if (user.Password == password)
                    return user.Role;
                return -1;
            }

            return -1;
        }
    }
}