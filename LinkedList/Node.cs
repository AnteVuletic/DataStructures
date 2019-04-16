using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node(object data, Node next)
        {
            Data = data;
            Next = next;
        }

    }
}
