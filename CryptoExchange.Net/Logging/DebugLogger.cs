using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace CryptoExchange.Net.Logging
{
    /// <summary>
    /// Default log writer, writes to debug
    /// </summary>
    public class DebugLogger: ILogger
    {
        /// <inheritdoc />
        public IDisposable BeginScope<TState>(TState state) => null!;

        /// <inheritdoc />
        public bool IsEnabled(LogLevel logLevel) => true;

        /// <inheritdoc />
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var logMessage = $"{MyDateTime.PreciseDateTime.Now:yyyy/MM/dd HH:mm:ss:ffffff} | {logLevel} | {formatter(state, exception)}";
            Trace.WriteLine(logMessage);
        }
    }
}
