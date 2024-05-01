using LojaLanche.Config.Ioc;
using LojaLanche.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Add conection to Database
string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection")!;
builder.Services.ConfigDatabase(mySqlConnection);
builder.Services.UpdateMigrationDatabase();

builder.Services.ConfigAuth(builder);

// Add IOC
builder.Services.ConfigRepositoryIoc();
builder.Services.ConfigServiceIoc();
builder.Services.ConfigCommandIoc();

builder.Services.AddControllersWithViews(options =>
{
    // Adiciona o filtro de exceção personalizado globalmente
    //options.Filters.Add(new CustomExceptionFilterAttribute());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Erro"); // Middleware para tratamento de erros
    app.UseStatusCodePagesWithRedirects("/Home/Index"); // Middleware para redirecionamento de páginas não encontradas
    app.UseHsts();
}

app.UseHttpsRedirection(); // Redireciona todas as solicitacoes HTTP para HTTPS
app.UseStaticFiles();

app.UseRouting();

using (var scope = app.Services.CreateScope())
{
    await scope.AddAdminRole();
    await scope.AddFuncionarioRole();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
