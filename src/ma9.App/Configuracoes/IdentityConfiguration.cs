using ma9.Data.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ma9.App.Configuracoes
{
    public static class IdentityConfiguration
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services)
        {
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<MeuIdentityDbContext>();

            return services;
        }
    }
}
