using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw42
{

    /// <summary>
    /// Исключение при попытке  удаления несуществующего элемента 
    /// </summary>
    [Serializable]
    class DeleteException : Exception
    {
        public DeleteException() { }
        public DeleteException(string message) : base(message) { }
        public DeleteException(string message, Exception inner) : base(message, inner) { }
        protected DeleteException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}