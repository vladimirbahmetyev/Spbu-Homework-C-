using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw42
{

    /// <summary>
    /// Исключение при попытке добавления уже существующего элемента
    /// </summary>
    [Serializable]
    class PushException : Exception
    {
        public PushException() { }
        public PushException(string message) : base(message) { }
        public PushException(string message, Exception inner) : base(message, inner) { }
        protected PushException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
