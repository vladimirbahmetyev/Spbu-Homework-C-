using System;

namespace Hw24
{
    /// <summary>
    /// Stack On List
    /// </summary>
    public class StackOnList : IStack
    {
        /// <summary>
        /// The Element Of Stack
        /// </summary>
        private class StackElement
        {
            public StackElement next { get; private set; }
            public int value { get; private set; }
            public StackElement(StackElement next, int value)
            {
                this.next = next;
                this.value = value;
            }
        }

        /// <summary>
        /// Length Of Stack
        /// </summary>
        private int length = 0;

        /// <summary>
        /// The first element of Stack
        /// </summary>
        private StackElement head = null;
            
        /// <summary>
        /// Add new element to stack
        /// </summary>
        /// <param name="value">New element</param>
        public void Push (int value)
        {
            head = new StackElement ( head, value );
            length++;
        }

        /// <summary>
        /// Pop element from head of stack
        /// </summary>
        /// <returns>Element from the head</returns>
        public int Pop ()
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }
            int element = head.value;
            head = head.next;
            length--;
            return element;
        }

        /// <summary>
        /// Checking if stack is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return null == head;
        }

        /// <summary>
        /// Return value without pop
        /// </summary>
        /// <returns>Value from head</returns>
        public int Peek()
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }
            return head.value;
        }

        /// <summary>
        /// Return length of stack
        /// </summary>
        /// <returns>Length value</returns>
        public int GetLength()
        {
            return length;
        }
    }
}
