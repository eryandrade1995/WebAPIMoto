using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIMotos.Models;

namespace WebAPIMotos.Context
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Adventure> Adventures { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<OffRoad> OffRoads { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Touring> Tourings { get; set; }
    }
}
