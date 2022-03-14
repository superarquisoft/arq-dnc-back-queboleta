using Domain.Interfaces.Logging;
using Microsoft.Extensions.Logging;
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

        /// <summary>
        /// LoggerService
        /// </summary>
        /// <param name="logger"></param>
        public LoggerService(ILogger<TEntidad> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// LogTrace
        /// </summary>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <param name="methodBase"></param>
        /// <param name="callerMemberName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task LogTrace(string id, string message, MethodBase methodBase, [CallerMemberName] string? callerMemberName = null, object? data = null) =>
            await Task.Run(() =>
            {
                _logger.LogTrace($"Id: {id} - Message: {message} - ClassName: {methodBase.DeclaringType?.Name} - Method: {callerMemberName}");

                if (data != null)
                    _logger.LogTrace($"Data: {data}");
            });

        /// <summary>
        /// LogDebug
        /// </summary>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <param name="methodBase"></param>
        /// <param name="callerMemberName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task LogDebug(string id, string message, MethodBase methodBase, [CallerMemberName] string? callerMemberName = null, object? data = null) =>
            await Task.Run(() =>
            {
                _logger.LogDebug($"Id: {id} - Message: {message} - ClassName: {methodBase.DeclaringType?.Name} - Method: {callerMemberName}");

                if (data != null)
                    _logger.LogDebug($"Data: {data}");
            });

        /// <summary>
        /// LogInfo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <param name="methodBase"></param>
        /// <param name="callerMemberName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task LogInfo(string id, string message, MethodBase methodBase, [CallerMemberName] string? callerMemberName = null, object? data = null) =>
            await Task.Run(() =>
            {
                _logger.LogInformation($"Id: {id} - Message: {message} - ClassName: {methodBase.DeclaringType?.Name} - Method: {callerMemberName}");

                if (data != null)
                    _logger.LogInformation($"Data: {data}");
            });

        /// <summary>
        /// LogWarning
        /// </summary>
        /// <param name="id"></param>
        /// <param name="exception"></param>
        /// <param name="methodBase"></param>
        /// <param name="callerMemberName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task LogWarning(string id, Exception exception, MethodBase methodBase, [CallerMemberName] string? callerMemberName = null, object? data = null) =>
            await Task.Run(() =>
            {
                _logger.LogWarning($"Id: {id} - Warning: {exception.Message} - ClassName: {methodBase.DeclaringType?.Name} - Method: {callerMemberName}");

                if (data != null)
                    _logger.LogWarning($"Data: {data}");
            });

        /// <summary>
        /// LogError
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="exception"></param>
        /// <param name="methodBase"></param>
        /// <param name="callerMemberName"></param>
        /// <returns></returns>
        public async Task LogError(string id, object data, Exception exception, MethodBase methodBase, [CallerMemberName] string? callerMemberName = null) =>
            await Task.Run(() =>
            {
                _logger.LogWarning($"Id: {id} - Exception: {exception.Message} - ClassName: {methodBase.DeclaringType?.Name} - Method: {callerMemberName}");

                if (data != null)
                    _logger.LogWarning($"Data: {data}");
            });
    }
}
