using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Maktabati.Data.Context;

namespace Maktabati
{
    public class BibliothequeContextFactory : IDesignTimeDbContextFactory<BibliothequeContext>
    {
        public BibliothequeContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BibliothequeContext>();
            optionsBuilder.UseSqlite("Data Source=Maktabati.db");

            return new BibliothequeContext(optionsBuilder.Options);
        }
    }
}