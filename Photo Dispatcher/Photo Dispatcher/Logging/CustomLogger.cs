using Microsoft.Extensions.Logging;

/// <summary>
/// Custom logger implementation to capture log messages and write them to both the console and a custom logger provider.
/// </summary>
public class CustomLogger : ILogger
{
    private readonly string _name;
    private readonly CustomLoggerProvider _provider;

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomLogger"/> class.
    /// </summary>
    /// <param name="name">The name of the logger instance.</param>
    /// <param name="provider">The custom logger provider instance.</param>
    public CustomLogger(string name, CustomLoggerProvider provider)
    {
        _name = name;
        _provider = provider;
    }

    /// <summary>
    /// Begins a logical operation scope. Not implemented in this custom logger.
    /// </summary>
    /// <typeparam name="TState">The type of the state.</typeparam>
    /// <param name="state">The identifier for the scope.</param>
    /// <returns>A disposable object that ends the logical operation scope on dispose.</returns>
    public IDisposable BeginScope<TState>(TState state) => null;

    /// <summary>
    /// Checks if the given log level is enabled.
    /// </summary>
    /// <param name="logLevel">The log level to check.</param>
    /// <returns>True if the log level is enabled; otherwise, false.</returns>
    public bool IsEnabled(LogLevel logLevel) => true;

    /// <summary>
    /// Logs a message with the given log level.
    /// </summary>
    /// <typeparam name="TState">The type of the state object to be logged.</typeparam>
    /// <param name="logLevel">The level of the log message.</param>
    /// <param name="eventId">The event id of the log message.</param>
    /// <param name="state">The state object to log.</param>
    /// <param name="exception">The exception related to this log (if any).</param>
    /// <param name="formatter">The function to create a log message from the state and exception.</param>
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
    {
        if(formatter == null)
            throw new ArgumentNullException(nameof(formatter));

        string message = formatter(state, exception);

        // Capture and print the log message based on the log level
        switch(logLevel)
        {
            case LogLevel.Information:
                _provider.InfoLogs.Add(message);
                Console.WriteLine($"INFO: {message}");
                break;
            case LogLevel.Warning:
                _provider.WarningLogs.Add(message);
                Console.WriteLine($"WARN: {message}");
                break;
            case LogLevel.Error:
                _provider.ErrorLogs.Add(message);
                Console.WriteLine($"ERROR: {message}");
                break;
        }
    }

}