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

        private Node _nodeByObject(int data)
        {
            var current = Head;
            while (current.Next != null)
            {
                if(current.Data == data) return current;
                current = current.Next;
            }
            return null;
        }
        public object Add(int index, int data)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));
            if (index > Count)
                index = Count;
            if (Empty) Head = new Node(data, Head);
            else
            {
                var current = _goToIndex(index);

                current.Next = new Node(data,null);
            }
            Count++;
            return data;
        }
        public object Push(int data)
        {
            return Add(Count, data);
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
            Count = 0;
        }

        public void Swap(int firstNumber, int secondNumber)
        {
            var firstNode = _nodeByObject(firstNumber);
            var secondNode = _nodeByObject(secondNumber);
            firstNode.Data = secondNumber;
            secondNode.Data = firstNumber;
        }

        public void BubbleSort()
        {
            for (var i = 0; i < Count; i++)
            {
                for (var k = 0; k < Count-i; k++)
                {
                    var firstNode = _goToIndex(k-1);
                    var secondNode = _goToIndex(k);
                    if( firstNode.Data > secondNode.Data )
                        Swap(firstNode.Data, secondNode.Data);
                }
            }
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
