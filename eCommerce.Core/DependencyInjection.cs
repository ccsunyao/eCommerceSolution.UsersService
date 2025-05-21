using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.ServiceContracts;
using eCommerce.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using eCommerce.Core.Validators;

namespace eCommerce.Core
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Extension method to add core services to the dependncy 
        /// injection container
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            // TO DO: Add services to the IoC container
            // Core services often include data access, 
            // caching and other low-level components.

            services.AddTransient<IUsersService, UsersService>();
            // services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();

            return services;
        }

    }
}
