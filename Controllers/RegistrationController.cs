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
        string _login = "admin";
        [HttpPost]
        public User Register([FromForm]User user)
        {
            if (user.Login != _login)
            {
                return user;
            }
            return null;
        }

    }
}