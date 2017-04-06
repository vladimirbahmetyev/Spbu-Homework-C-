using System;

namespace Hw21
{
    public class Program
    {
        public class Stack
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

            private StackElement head = null;
            
            public void Push (int value)
            {
                head = new StackElement ( head, value );
            }

            public int Pop ()
            {
                if (head == null)
                {
                    return -1;
                }
                int element = head.value;
                head = head.next;
                return element; 
            }

            public bool IsStackEmpty()
            {
                return null == head;
            }            
        }

        static void Main(string[] args)
        {
        }
    }
}
