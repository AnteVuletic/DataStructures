using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Head { get; private set; }

        public BinaryTree()
        {
            Head = new Node();
        }

        public BinaryTree(Node head)
        {
            Head = head;
        }
        public static Node Add(int value, Node headNode)
        {
            if (headNode.Value == 0)
                headNode.Value = value;
            if (headNode.Value < value)
            {
                if(headNode.Left == null)
                    headNode.Left = new Node(value);
                else
                    Add(value, headNode.Left);
            }

            if (headNode.Value > value)
            {
                if (headNode.Right == null)
                    headNode.Right = new Node(value);
                else
                    Add(value, headNode.Right);
            }

            return headNode;
        }

        public static Node LogAll(Node headNode)
        {
            if (headNode.Left != null)
            {
                LogAll(headNode.Left);
            }

            if (headNode.Right != null)
            {
                LogAll(headNode.Right);
            }

            Console.WriteLine(headNode.Value);
            return headNode;
        }
    }
}
