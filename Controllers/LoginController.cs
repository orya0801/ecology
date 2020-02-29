using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        string _login = "admin";
        string _password = "admin";
        [HttpPost]
        public int Login([FromHeader]string login, [FromHeader] string password)
        {
            if (login == _login && password == _password)
                return 1;
            return -1;
        }
    }
}