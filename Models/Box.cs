using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class Box
    {
        [Key]
        public int Id { get; set; }
        public string Adress { get; set; }
        public string Location { get; set; }
        public int Fullness { get; set; }
        public string Owner { get; set; }
    }
}
