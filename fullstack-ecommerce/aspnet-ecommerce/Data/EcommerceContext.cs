using Microsoft.EntityFrameworkCore;
using Models;

namespace Data;

public class EcommerceContext : DbContext
{
    public EcommerceContext(DbContextOptions<EcommerceContext> options)
        : base(options)
    {
        
    }

    public DbSet<Product> Products { get; set; }
}