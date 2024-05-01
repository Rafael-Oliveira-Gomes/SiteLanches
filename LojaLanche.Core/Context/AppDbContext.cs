using LojaLanche.Core.Model;
using LojaLanche.Core.Model.Auth.Role;
using LojaLanche.Core.Model.Auth.User;
using LojaLanche.Core.Model.Carrinho;
using LojaLanche.Core.Model.Pedido;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LojaLanche.Core.Context
{
    public class AppDbContext : IdentityDbContext<UserBase, ApplicationRole, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<ApplicationUser> User { get; set; } = null!;
        public DbSet<ApplicationRole> Role { get; set; } = null!;
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}
