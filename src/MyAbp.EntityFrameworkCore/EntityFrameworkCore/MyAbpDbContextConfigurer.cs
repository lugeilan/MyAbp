using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyAbp.EntityFrameworkCore
{
    public static class MyAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyAbpDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyAbpDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
