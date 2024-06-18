using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Photo_Dispatcher;

namespace PhotoDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var logger = serviceProvider.GetService<ILogger<Program>>();
            logger.LogInformation("Application starting...");

            try
            {
                var photoDispatcher = serviceProvider.GetService<PhotoDispatch>();
                var paths = serviceProvider.GetService<IOptions<Paths>>().Value;
                photoDispatcher.DispatchPhotos(paths.CsvFilePath);
                logger.LogInformation("Application terminated successfully.");
            }
            catch(Exception ex)
            {
                logger.LogError(ex, "An error occurred during execution.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Build configuration
            var configuration = new ConfigurationBuilder()
                             .SetBasePath(Directory.GetCurrentDirectory())
                             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                             .Build();

            services.AddSingleton(configuration);

            // Configure logging
            services.AddLogging(configure => configure.AddConsole())
                    .AddTransient<EmailSender>()
                    .AddTransient<CsvLoader>()
                    .AddTransient<PhotoDispatch>();

            // Bind configuration sections to options
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.Configure<Paths>(configuration.GetSection("Paths"));
        }

    }
}