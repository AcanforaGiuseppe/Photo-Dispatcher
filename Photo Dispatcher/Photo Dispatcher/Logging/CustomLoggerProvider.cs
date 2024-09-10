/*
© Giuseppe Acanfora - PHOTODISPATCHER 2024. Tutti i diritti riservati.
*/
using Microsoft.Extensions.Logging;

/// <summary>
/// Custom logger provider to create instances of the custom logger and store log messages.
/// </summary>
public class CustomLoggerProvider : ILoggerProvider
{
    public List<string> InfoLogs { get; } = new List<string>(); // List to store info log messages
    public List<string> WarningLogs { get; } = new List<string>(); // List to store warning log messages
    public List<string> ErrorLogs { get; } = new List<string>(); // List to store error log messages

    /// <summary>
    /// Creates a new instance of the <see cref="CustomLogger"/> class.
    /// </summary>
    /// <param name="categoryName">The name of the logger category.</param>
    /// <returns>A new instance of the <see cref="CustomLogger"/> class.</returns>
    public ILogger CreateLogger(string categoryName)
    {
        return new CustomLogger(categoryName, this);
    }

    /// <summary>
    /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    /// </summary>
    public void Dispose()
    {
        // No resources to dispose
    }

}