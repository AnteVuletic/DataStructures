using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head { get; private set; }
        public int Count { get; private set; }

        public bool Empty => Count == 0;

        public LinkedList()
        {
            Head = null;
            Count = 0;
        }

        private Node _goToIndex(int index)
        {
            var current = Head;
            for (var i = 0; i < index - 1; i++)
                current = current.Next;
            return current;
        }
        public object Add(int index, object o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));
            if (index > Count)
                index = Count;
            if (Empty) Head = new Node(o, Head);
            else
            {
                var current = _goToIndex(index);

                current.Next = new Node(o,current.Next);
            }
            Count++;
            return o;
        }
        public object Push(object o)
        {
            return Add(Count, o);
        }

        public object Remove(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));
            if (Empty)
                return null;
            if (index > Count)
                index = Count - 1;
            var current = Head;
            object result = null;
            if (index == 0)
            {
                result = current.Data;
                Head = current.Next;
            }
            else
            {
                current = _goToIndex(index -1 );
                result = current.Next.Data;
                current.Next = current.Next.Next;
            }

            Count--;
            return result;
        }

        public object Pop()
        {
            return Remove(Count - 1);
        }

        public void Clear()
        {
            Head = null;
        }

        public static Node LogAll(Node headNode)
        {
            Console.WriteLine(headNode.Data);
            if (headNode.Next != null)
                LogAll(headNode.Next);
            return headNode;
        }
    }
}
