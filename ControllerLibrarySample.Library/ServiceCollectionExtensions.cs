using Microsoft.Extensions.DependencyInjection;
using System;

namespace ControllerLibrarySample.Library
{
    public static class ServiceCollectionExtensions
    {
        public static void AddSampleLibrary(
            this IServiceCollection services,
            Action<ExampleOptions> setupAction = null
        )
        {
            // Configure the example options and call the setup action if it has been provided.
            services.Configure<ExampleOptions>(options => setupAction?.Invoke(options));

            services.AddTransient<IExampleService, ExampleService>();
        }
    }
}
