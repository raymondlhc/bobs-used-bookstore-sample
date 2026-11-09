using Microsoft.AspNetCore.Builder;

namespace Bookstore.Web.Startup
{
    public static class ApplicationServicesSetup
    {
        public static WebApplicationBuilder AddApplicationServices(this WebApplicationBuilder builder)
        {
            builder.ConfigureConfiguration();

            builder.ConfigureServices();

            builder.ConfigureAuthentication();

            builder.ConfigureDependencyInjection();

            return builder;
        }
    }
}
