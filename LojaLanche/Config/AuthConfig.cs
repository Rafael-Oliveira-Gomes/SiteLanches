using LojaLanche.Data.Model.Auth.Role;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace LojaLanche.Config
{
    public static class AuthConfig
    {
        public static void ConfigAuth(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = builder.Configuration["JWT:ValidIssuer"],

                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["JWT:ValidAudience"],

                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]!)),

                    ValidateLifetime = true
                };
            });
        }
        public static async Task AddAdminRole(this IServiceScope scope)
        {
            try
            {
                // Obter o serviço de gerenciamento de roles
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

                // Verificar se a role "Admin" já existe
                var adminRoleExists = await roleManager.RoleExistsAsync("Admin");

                if (!adminRoleExists)
                {
                    // Criar uma nova instância da classe "ApplicationRole"
                    var adminRole = new ApplicationRole
                    {
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    };

                    // Criar a role "Admin"
                    await roleManager.CreateAsync(adminRole);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
        public static async Task AddFuncionarioRole(this IServiceScope scope)
        {
            try
            {
                // Obter o serviço de gerenciamento de roles
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

                // Verificar se a role "Funcionario" já existe
                var funcionarioRoleExists = await roleManager.RoleExistsAsync("Funcionario");

                if (!funcionarioRoleExists)
                {
                    // Criar uma nova instância da classe "ApplicationRole"
                    var funcionarioRole = new ApplicationRole
                    {
                        Name = "Funcionario",
                        NormalizedName = "FUNCIONARIO"
                    };

                    // Criar a role "Admin"
                    await roleManager.CreateAsync(funcionarioRole);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
