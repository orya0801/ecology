using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Key]
        public string Login { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
