using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAppTutoriaL.Models
{
    public class WorldContext : IdentityDbContext<WebAppUser>
    {
        public WorldContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Stop> Stops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = Startup.Configuration["Data:WorldContextConnection"];

            optionsBuilder.UseSqlServer(connection);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
