using Microsoft.EntityFrameworkCore;
using SalesCET97.Web.Data.Entities;

namespace SalesCET97.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Country> Countries { get; set; }

    }
}
