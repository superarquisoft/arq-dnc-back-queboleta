using Domain.Interfaces.Logging;
using Helpers.Commons.AppSettings;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Helpers.Commons.Logging
{
    /// <summary>
    /// LoggerService
    /// </summary>
    /// <typeparam name="TEntidad"></typeparam>
    public class LoggerService<TEntidad> : ILoggerService<TEntidad>
    {
        private readonly ILogger<TEntidad> _logger;
        private readonly IOptions<QueBoletaAppSettings> _appSettings;

        /// <summary>
        /// LoggerService
        /// </summary>
        /// <param name="logger"></param>
        public LoggerService(ILogger<TEntidad> logger, IOptions<QueBoletaAppSettings> appSettings)
        {
            _logger = logger;
            _appSettings = appSettings;
        }

        /// <summary>
        /// Consoles the error log.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="methodBase">The method base.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="callerMemberName">Name of the caller member.</param>
        public void ConsoleErrorLog(string message, MethodBase methodBase, Exception exception, [CallerMemberName] string callerMemberName = null)
        {

            LogInternal(LogLevel.Error, message, methodBase, ex: exception, callerMemberName: callerMemberName);
        }


        /// <summary>
        /// Consoles the information log.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="methodBase">The method base.</param>
        /// <param name="data">The data.</param>
        /// <param name="callerMemberName">Name of the caller member.</param>
        public void ConsoleInfoLog(string message, MethodBase methodBase, object data = null, [CallerMemberName] string callerMemberName = null)
        {
            LogInternal(LogLevel.Information, message, methodBase, data, callerMemberName: callerMemberName);
        }

        /// <summary>
        /// Consoles the trace log.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="data">The data.</param>
        /// <param name="methodBase">The method base.</param>
        /// <param name="callerMemberName">Name of the caller member.</param>
        public void ConsoleTraceLog(string message, MethodBase methodBase, object data = null, [CallerMemberName] string callerMemberName = null)
        {
            LogInternal(LogLevel.Trace, message, methodBase, data, callerMemberName: callerMemberName);
        }

        /// <summary>
        /// Consoles the warning log.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="methodBase">The method base.</param>
        /// <param name="data">The data.</param>
        /// <param name="callerMemberName">Name of the caller member.</param>
        /// <returns></returns>
        public void ConsoleWarningLog(string message, MethodBase methodBase, object data = null, [CallerMemberName] string callerMemberName = null)
        {
            LogInternal(LogLevel.Warning, message, methodBase, data, callerMemberName: callerMemberName);
        }

        /// <summary>
        /// Consoles the process log.
        /// </summary>
        /// <param name="eventName">Name of the event.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="data">The data.</param>
        /// <param name="callerMemberName">Name of the caller member.</param>
        public void ConsoleProcessLog(string eventName, string id, object data = null, [CallerMemberName] string callerMemberName = null)
        {
            _logger.LogInformation($"ClassName: {eventName} - MethodName: {callerMemberName} - Id: {id}");

            if (data is not null)
            {
                _logger.LogInformation($"DATA: {data}");
            }
        }

        private void LogInternal(LogLevel logLevel, string message, MethodBase methodBase, object data = null,
            Exception ex = null, [CallerMemberName] string callerMemberName = null)
        {
            string eventName = FormatEventName(logLevel, _appSettings.Value, methodBase, callerMemberName);
            _logger.Log(logLevel, "{eventName} - {message}", eventName, message);

            if (data is not null)
            {
                _logger.Log(logLevel, $"DATA: {data}");
            }

            if (ex is not null)
            {
                _logger.Log(logLevel, $"EXCEPTION: {ex}");
            }
        }

        private string FormatEventName(LogLevel logLevel, QueBoletaAppSettings conciliadorApp, MethodBase methodBase, string callerMemberName)
        {
            Type declaringType = methodBase.DeclaringType.DeclaringType ?? methodBase.DeclaringType;

            return $"{logLevel.ToString().ToUpper()} - {conciliadorApp.AppName}.{declaringType.Name}.{callerMemberName}";
        }
    }
}
