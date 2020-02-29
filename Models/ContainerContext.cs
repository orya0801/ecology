using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class ContainerContext
    {
        public DbSet<Container> Containers { get; set; }
    }
}
