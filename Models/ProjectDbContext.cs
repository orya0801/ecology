using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Box> Boxes { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
