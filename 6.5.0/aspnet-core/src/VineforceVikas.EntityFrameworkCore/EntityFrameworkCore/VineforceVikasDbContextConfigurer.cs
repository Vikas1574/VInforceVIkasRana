using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace VineforceVikas.EntityFrameworkCore
{
    public static class VineforceVikasDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VineforceVikasDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VineforceVikasDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
