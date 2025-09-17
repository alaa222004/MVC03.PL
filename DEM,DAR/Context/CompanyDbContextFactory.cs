using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DEM_DAR.Context
{
    public class CompanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
    {
        public CompanyDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CompanyDbContext>();

           
            optionsBuilder.UseSqlServer(
                "Server=.;Database=YourDatabaseName;Trusted_Connection=True;TrustServerCertificate=True");

            return new CompanyDbContext(optionsBuilder.Options);
        }
    }
}
