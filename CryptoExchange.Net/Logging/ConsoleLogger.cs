using Microsoft.Extensions.Logging;
using System;

namespace CryptoExchange.Net.Logging
{
    /// <summary>
    /// Log to console
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <inheritdoc />
        public IDisposable BeginScope<TState>(TState state) => null!;

        /// <inheritdoc />
        public bool IsEnabled(LogLevel logLevel) => true;

        /// <inheritdoc />
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var logMessage = $"{MyDateTime.PreciseDateTime.Now:yyyy/MM/dd HH:mm:ss:ffffff} | {logLevel} | {formatter(state, exception)}";
            Console.WriteLine(logMessage);
        }
    }
}
