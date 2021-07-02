using ma9.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ma9.App.Configuracoes
{
    public static class ContextConfig
    {
        public static IServiceCollection AddContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MeuIdentityDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MeuIdentityConnectionString")));

            return services;
        }
    }
}
