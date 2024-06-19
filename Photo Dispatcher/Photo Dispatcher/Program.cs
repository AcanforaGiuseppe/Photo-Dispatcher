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
            // Create a new service collection for dependency injection
            var serviceCollection = new ServiceCollection();
            // Configure services and dependencies
            ConfigureServices(serviceCollection);

            // Build the service provider from the service collection
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Get the logger service and log that the application is starting
            var logger = serviceProvider.GetService<ILogger<Program>>();
            logger.LogInformation("Application starting...");

            try
            {
                // Resolve the PhotoDispatch service from the service provider
                var photoDispatcher = serviceProvider.GetService<PhotoDispatch>();
                // Resolve the Paths configuration from the service provider
                var paths = serviceProvider.GetService<IOptions<Paths>>().Value;
                // Call the DispatchPhotos method with the CSV file path
                photoDispatcher.DispatchPhotos(paths.CsvFilePath);
                // Log that the application terminated successfully
                logger.LogInformation("Application terminated successfully.");
            }
            catch(Exception ex)
            {
                // Log an error message if an exception occurs
                logger.LogError(ex, "An error occurred during execution.");
            }

            // Prevent the console window from closing immediately
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Configure services and dependencies
        private static void ConfigureServices(IServiceCollection services)
        {
            // Build configuration
            var configuration = new ConfigurationBuilder()
                             .SetBasePath(Directory.GetCurrentDirectory()) // Set the base path to the current directory
                             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Add the JSON configuration file
                             .Build(); // Build the configuration

            // Register the configuration as a singleton service
            services.AddSingleton(configuration);

            // Configure logging to use the console
            services.AddLogging(configure => configure.AddConsole())
                    .AddTransient<EmailSender>() // Register EmailSender as a transient service
                    .AddTransient<CsvLoader>() // Register CsvLoader as a transient service
                    .AddTransient<PhotoDispatch>(); // Register PhotoDispatch as a transient service

            // Bind configuration sections to options
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.Configure<Paths>(configuration.GetSection("Paths"));
        }

    }
}