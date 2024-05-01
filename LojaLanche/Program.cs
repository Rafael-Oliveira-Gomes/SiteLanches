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

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

using (var scope = app.Services.CreateScope())
{
    await scope.AddAdminRole();
    await scope.AddFuncionarioRole();
}

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
