namespace Client.Persistence.WebApp.Extensions.ExceptionFilter
{
    public static class ExceptionFilterConfig
    {
        public static void AddExceptionFilterConfiguration(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(typeof(ExceptionFilter));
            });
        }
    }
}
