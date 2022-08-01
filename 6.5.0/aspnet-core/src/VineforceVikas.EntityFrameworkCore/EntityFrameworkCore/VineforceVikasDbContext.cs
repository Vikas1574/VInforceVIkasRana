using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VineforceVikas.Authorization.Roles;
using VineforceVikas.Authorization.Users;
using VineforceVikas.MultiTenancy;
using VineforceVikas.Country;

namespace VineforceVikas.EntityFrameworkCore
{
    public class VineforceVikasDbContext : AbpZeroDbContext<Tenant, Role, User, VineforceVikasDbContext>
    {
        public DbSet<country> countries { get; set; }

        /* Define a DbSet for each entity of the application */
        
        public VineforceVikasDbContext(DbContextOptions<VineforceVikasDbContext> options)
            : base(options)
        {
        }
    }
}
