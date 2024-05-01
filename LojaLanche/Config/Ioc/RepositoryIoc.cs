using LojaLanche.Core.Interface.Repository;
using LojaLanche.Core.Repository;

namespace LojaLanche.Config.Ioc
{
    public static class RepositoryIoc
    {
        public static void ConfigRepositoryIoc(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
