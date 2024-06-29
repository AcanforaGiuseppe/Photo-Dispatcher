using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Photo_Dispatcher
{
    static class Program
    {
        private static IConfiguration _configuration;
        private static CustomLoggerProvider _customLoggerProvider;

        static void Main(string[] args)
        {
            // Initialize the custom logger provider
            _customLoggerProvider = new CustomLoggerProvider();

            // Create a new service collection for dependency injection
            var serviceCollection = new ServiceCollection();
            // Configure services and dependencies
            ConfigureServices(serviceCollection);

            // Build the service provider from the service collection
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Get the logger service and log that the application is starting
            var logger = serviceProvider.GetService<ILogger<PhotoDispatch>>();
            LogInformation(logger, "Application starting...");

            try
            {
                // Resolve the PhotoDispatch service from the service provider
                var photoDispatcher = serviceProvider.GetService<PhotoDispatch>();
                // Resolve the Paths configuration from the service provider
                var paths = serviceProvider.GetService<IOptions<Paths>>().Value;
                // Call the DispatchPhotos method with the CSV file path
                photoDispatcher.DispatchPhotos(paths.CsvFilePath);
                // Log that the application terminated successfully
                LogInformation(logger, "Application terminated successfully.");
            }
            catch(Exception ex)
            {
                // Log an error message if an exception occurs
                LogError(logger, ex, "An error occurred during execution.");
            }

            // Write the report file
            WriteReport();

            // Prevent the console window from closing immediately
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Configure services and dependencies
        private static void ConfigureServices(IServiceCollection services)
        {
            // Build configuration
            _configuration = new ConfigurationBuilder()
                          .SetBasePath(Path.GetDirectoryName(typeof(Program).Assembly.Location)) // Set the base path to the current directory
                          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Add the JSON configuration file
                          .Build(); // Build the configuration

            // Register the configuration as a singleton service
            services.AddSingleton(_configuration);

            // Configure logging to use both the console and the custom logger provider
            services.AddLogging(configure =>
                                            {
                                                configure.AddConsole();
                                                configure.AddProvider(_customLoggerProvider);
                                            })
                    .AddTransient<EmailSender>() // Register EmailSender as a transient service
                    .AddTransient<CsvLoader>() // Register CsvLoader as a transient service
                    .AddTransient<PhotoDispatch>();  // Register PhotoDispatch as a transient service

            // Bind configuration sections to options
            services.Configure<EmailSettings>(_configuration.GetSection("EmailSettings"));
            services.Configure<Paths>(_configuration.GetSection("Paths"));
        }

        // Logging methods
        private static void LogInformation(ILogger logger, string message)
        {
            logger.LogInformation(message);
            _customLoggerProvider.InfoLogs.Add(message);
        }

        private static void LogWarning(ILogger logger, string message)
        {
            logger.LogWarning(message);
            _customLoggerProvider.WarningLogs.Add(message);
        }

        private static void LogError(ILogger logger, Exception ex, string message)
        {
            logger.LogError(ex, message);
            _customLoggerProvider.ErrorLogs.Add($"{message} - {ex.Message}");
        }

        // Method to write the report file
        private static void WriteReport()
        {
            string reportFilePath = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "report.txt");

            using(var writer = new StreamWriter(reportFilePath))
            {
                writer.WriteLine("Info Logs:");
                foreach(var log in _customLoggerProvider.InfoLogs)
                    writer.WriteLine(log);

                writer.WriteLine("\nWarning Logs:");
                foreach(var log in _customLoggerProvider.WarningLogs)
                    writer.WriteLine(log);

                writer.WriteLine("\nError Logs:");
                foreach(var log in _customLoggerProvider.ErrorLogs)
                    writer.WriteLine(log);
            }

            Console.WriteLine($"Report written to {reportFilePath}");
        }

    }
}