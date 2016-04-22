using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Assignment.Models.Concrete
{
    public class EFDbContext : DbContext 
    {
        public DbSet<Company> Companies { get; set; }
    }
}