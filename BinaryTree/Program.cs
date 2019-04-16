using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var binaryTree = new BinaryTree();
            BinaryTree.Add(5, binaryTree.Head);
            BinaryTree.Add(4, binaryTree.Head);
            BinaryTree.Add(3, binaryTree.Head);
            BinaryTree.Add(6, binaryTree.Head);
            BinaryTree.Add(9, binaryTree.Head);
            BinaryTree.Add(1, binaryTree.Head);
            BinaryTree.LogAll(binaryTree.Head);
        }
    }
}
