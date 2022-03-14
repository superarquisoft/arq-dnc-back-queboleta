using System.Reflection;
using System.Runtime.CompilerServices;

namespace Domain.Interfaces.Logging
{
    public interface ILoggerService<TEntity>
    {
        /// <summary>
        /// LogTrace
        /// </summary>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <param name="methodBase"></param>
        /// <param name="callerMemberName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task LogTrace(string id, string message, MethodBase methodBase, [CallerMemberName] string? callerMemberName = null, object? data = null);

        /// <summary>
        /// LogDebug
        /// </summary>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <param name="methodBase"></param>
        /// <param name="callerMemberName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task LogDebug(string id, string message, MethodBase methodBase, [CallerMemberName] string? callerMemberName = null, object? data = null);

        /// <summary>
        /// LogInfo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <param name="methodBase"></param>
        /// <param name="callerMemberName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task LogInfo(string id, string message, MethodBase methodBase, [CallerMemberName] string? callerMemberName = null, object? data = null);

        /// <summary>
        /// LogWarning
        /// </summary>
        /// <param name="id"></param>
        /// <param name="exception"></param>
        /// <param name="methodBase"></param>
        /// <param name="callerMemberName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task LogWarning(string id, Exception exception, MethodBase methodBase, [CallerMemberName] string? callerMemberName = null, object? data = null);

        /// <summary>
        /// LogError
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="exception"></param>
        /// <param name="methodBase"></param>
        /// <param name="callerMemberName"></param>
        /// <returns></returns>
        Task LogError(string id, object data, Exception exception, MethodBase methodBase, [CallerMemberName] string? callerMemberName = null);
    }
}
