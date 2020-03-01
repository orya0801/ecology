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
        [HttpPost]
        public int Login([FromHeader] string login, [FromHeader]string password)
        {
            List<User> users = RegistrationController.Users;
            foreach (User user in users)
            {
                if ((user.Login == login) && (user.Password == password))
                {
                    return user.Role;
                }
            }
            return -1;
        }
    }
}