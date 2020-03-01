using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class BoxesContext : DbContext
    {
        public DbSet<Box> Boxes { get; set; }

        public BoxesContext(DbContextOptions<BoxesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
