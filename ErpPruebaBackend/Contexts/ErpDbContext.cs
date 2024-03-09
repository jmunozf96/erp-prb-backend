using ErpSecurity.infrastructure.entities;
using ErpSecurity.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ErpPruebaBackend.Contexts
{
    public class ErpDbContext : DbContext, SecurityDbContext
    {
        public ErpDbContext(DbContextOptions<ErpDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
