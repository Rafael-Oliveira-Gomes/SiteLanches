using LojaLanche.Core.Command;
using LojaLanche.Core.Interface.Command;

namespace LojaLanche.Config.Ioc
{
    public static class CommandIoc
    {
        public static void ConfigCommandIoc(this IServiceCollection services)
        {
            services.AddScoped<IProdutoCommand, ProdutoCommand>();
        }
    }
}
