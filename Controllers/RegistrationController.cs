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
    public class RegistrationController : Controller
    {
        UsersContext db;
        public RegistrationController(UsersContext context)
        {
            db = context;
        }

        string _login = "admin";
        [HttpPost]
        public User Register([FromHeader]User user)
        {
            if (db.Users.Find(user.Login) == null)
            {
                db.Add(user);
                db.SaveChanges();
                return user;
            }
            return null;
        }

    }
}