using LojaLanche.Core.Interface.Service;
using LojaLanche.Core.Service;

namespace LojaLanche.Config.Ioc
{
    public static class ServiceIoc
    {
        public static void ConfigServiceIoc(this IServiceCollection services)
        {
            services.AddScoped<IProdutoService, ProdutoService>();
        }
    }
}
