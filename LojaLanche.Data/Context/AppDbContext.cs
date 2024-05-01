using LojaLanche.Data.Model;
using LojaLanche.Data.Model.Auth.Role;
using LojaLanche.Data.Model.Auth.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LojaLanche.Data.Context
{
    public class AppDbContext : IdentityDbContext<UserBase, ApplicationRole, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<ApplicationUser> User { get; set; }
        public DbSet<ApplicationRole> Role { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
    }
}
