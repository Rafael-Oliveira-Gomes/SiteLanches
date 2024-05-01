using LojaLanche.Core.Interface;
using LojaLanche.Core.Interface.Repository;
using LojaLanche.Core.Repository;

namespace LojaLanche.Config.Ioc
{
    public static class RepositoryIoc
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ILancheRepository, LancheRepository>();
        }
    }
}
