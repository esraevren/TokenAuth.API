using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TokenAuth.API.Models
{
    public class AppDbContext(DbContextOptions options) : IdentityDbContext<AppUser, AppRole, Guid>(options)
    {
        public DbSet<Product> Products { get; set; } = default!;
    }
}
