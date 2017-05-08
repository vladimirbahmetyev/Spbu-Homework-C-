using System;

namespace Hw42
{
    /// <summary>
    /// Исключение при попытке добавления уже существующего элемента
    /// </summary>
    [Serializable]
    public class PushException : Exception
    {
        public PushException() { }
        public PushException(string message) : base(message) { }
        public PushException(string message, Exception inner) : base(message, inner) { }
        protected PushException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
