using ErpSecurity.infrastructure.entities;
using Microsoft.EntityFrameworkCore;

namespace ErpSecurity.Infrastructure.Contexts
{
    public interface SecurityDbContext
    {
        public DbSet<UserEntity> Users { get; set; }
    }
}
