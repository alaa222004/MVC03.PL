global using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM_DAR.Context
{
    public class CompanyDbContext(DbContextOptions<CompanyDbContext>options):DbContext (options)
    {
        public DbSet<Department> Departments { get; set; }

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //     modelBuilder.ApplyConfigurationsFromAssembly(typeof(Cam);
        //    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
  
}
