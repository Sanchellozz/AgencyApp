using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AgencyApp.Models;

namespace AgencyApp.Data
{
    public class AgencyDBContext : DbContext
    {
        public DbSet<Degree> Degrees { get; set; }

        public DbSet<License> Licenses { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Agent> Agents { get; set; }

        public AgencyDBContext (DbContextOptions<AgencyDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        
    }
}
