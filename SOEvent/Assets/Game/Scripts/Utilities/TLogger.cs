using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace Game.Scripts.Utilities
{
    public static class TLogger
    {
        /// <summary>
        /// Only Works Editor Mode 
        /// </summary>
        private const string Prefix = "[TT]";

        [Conditional("UNITY_EDITOR")]
        public static void Log(object message)
        {
            Debug.Log($"<color=orange><b>{Prefix}</b></color> {message}");
        }

        [Conditional("UNITY_EDITOR")]
        public static void LogWarning(object message)
        {
            Debug.LogWarning($"<color=orange><b>{Prefix}</b></color> {message}");
        }

        [Conditional("UNITY_EDITOR")]
        public static void LogError(object message)
        {
            Debug.LogError($"<color=red><b>{Prefix}</b></color> {message}");
        }

        [Conditional("UNITY_EDITOR")]
        public static void LogException(System.Exception exception)
        {
            Debug.LogException(exception);
        }
    }
}