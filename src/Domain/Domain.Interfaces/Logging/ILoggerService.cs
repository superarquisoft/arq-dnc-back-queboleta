using System.Reflection;
using System.Runtime.CompilerServices;

namespace Domain.Interfaces.Logging
{
    public interface ILoggerService<TEntity>
    {
        /// <summary>
        /// Consoles the error log.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="methodBase">The method base.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="callerMemberName">Name of the caller member.</param>
        void ConsoleErrorLog(string message, MethodBase methodBase, Exception exception,
            [CallerMemberName] string? callerMemberName = null);

        /// <summary>
        /// Consoles the information log.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="methodBase">The method base.</param>
        /// <param name="data">The data.</param>
        /// <param name="callerMemberName">Name of the caller member.</param>
        void ConsoleInfoLog(string message, MethodBase methodBase, object? data = null,
            [CallerMemberName] string? callerMemberName = null);

        /// <summary>
        /// Consoles the trace log.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="methodBase">The method base.</param>
        /// <param name="data">The data.</param>
        /// <param name="callerMemberName">Name of the caller member.</param>
        void ConsoleTraceLog(string message, MethodBase methodBase, object? data = null,
            [CallerMemberName] string? callerMemberName = null);

        /// <summary>
        /// Consoles the warning log.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="methodBase">The method base.</param>
        /// <param name="data">The data.</param>
        /// <param name="callerMemberName">Name of the caller member.</param>
        public void ConsoleWarningLog(string message, MethodBase methodBase, object? data = null,
            [CallerMemberName] string? callerMemberName = null);

        /// <summary>
        /// Consoles the process log.
        /// </summary>
        /// <param name="eventName">Name of the event.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="data">The data.</param>
        /// <param name="callerMemberName">Name of the caller member.</param>
        void ConsoleProcessLog(string eventName, string id, object? data = null,
            [CallerMemberName] string? callerMemberName = null);
    }
}
