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

        [HttpPost]
        public User Register([FromHeader] int id,[FromHeader] string login,[FromHeader] string password,[FromHeader] int role,[FromHeader] string name)
        {
            User user = new User();
            user.Id = id;
            user.Login = login;
            user.Name = name;
            user.Password = password;
            user.Role = role;
            if (db.Users.Find(user.Login) == null)
            {
                db.Add(user);
                db.SaveChanges();
                return user;
            }
            return id;
        }

    }
}