using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class HrManagementContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-TOD8TAV\SQLEXPRESS;Database=HrManagementDb;Trusted_Connection=true");
        }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
