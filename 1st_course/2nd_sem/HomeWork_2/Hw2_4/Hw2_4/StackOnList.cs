using System;

namespace Hw24
{
    public class StackOnList : IStack
    {
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

        private int length = 0;

        private StackElement head = null;
            
        public void Push (int value)
        {
            head = new StackElement ( head, value );
            length++;
        }

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

        public bool IsEmpty()
        {
            return null == head;
        }

        public int Peek()
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }
            return head.value;
        }

        public int GetLength()
        {
            return length;
        }
    }
}
