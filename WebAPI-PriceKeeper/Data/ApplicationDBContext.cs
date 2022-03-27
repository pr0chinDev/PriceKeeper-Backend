using Microsoft.EntityFrameworkCore;
using WebAPI_PriceKeeper.Models;

namespace WebAPI_PriceKeeper.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){ }
            public DbSet<Product> Products { get; set; }
    
    }
}


