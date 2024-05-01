using LojaLanche.Data.Context;
using LojaLanche.Data.Model.Auth.Role;
using LojaLanche.Data.Model.Auth.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace LojaLanche.Config
{
    public static class DatabaseConfig
    {
        public static void ConfigDatabase(this IServiceCollection services, string mySqlConnection)
        {
            services.AddDbContextPool<AppDbContext>(options =>
            options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));

            services.AddIdentity<UserBase, ApplicationRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
        }

        public static void UpdateMigrationDatabase(this IServiceCollection services)
        {
            // Configure database migration
            using (var scope = services.BuildServiceProvider().CreateScope())
            {
                using (var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>())
                {
                    if (dbContext.Database.GetPendingMigrations().Any())
                    {
                        dbContext.Database.Migrate();
                    }
                }
            }
        }
    }
}
