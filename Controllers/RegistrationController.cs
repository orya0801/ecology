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
        public static List<User> Users = new List<User>();


        [HttpPost]
        public User Register([FromHeader] int id,[FromHeader] string login,[FromHeader] string password,[FromHeader] int role,[FromHeader] string name)
        {
            User user = new User();
            user.Id = id;
            user.Login = login;
            user.Name = name;
            user.Password = password;
            user.Role = role;
            foreach (User elem in Users)
            {
                if (elem.Login == user.Login)
                {
                    return null;
                }
            }
            Users.Add(user);
            return Users.Last();
        }

    }
}