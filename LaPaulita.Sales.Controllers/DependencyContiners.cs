namespace LaPaulita.Sales.Controllers
{
    public static class DependencyContiners
    {
        public static IServiceCollection AddSalesControllers(
            this IServiceCollection services)
        {
            services.AddScoped<ICreateOrderController, CreateOrderController>();
            return services;
        }
    }
}
