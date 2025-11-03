using Microsoft.Extensions.DependencyInjection;

namespace eAppointmentServer.Application
{
    public static class DependencyInjection
    {
        // Uygulama katmanındaki MediatR servislerini otomatik olarak projeye ekler.
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            });
            return services;
        }
    }
}
