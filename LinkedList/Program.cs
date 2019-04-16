using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var linkedListExample = new LinkedList();
            linkedListExample.Push(1);
            linkedListExample.Push(2);
            linkedListExample.Push(3);
            linkedListExample.Push(4);
            LinkedList.LogAll(linkedListExample.Head);
            Console.WriteLine();
            linkedListExample.Swap(1,2);
            linkedListExample.Swap(2,3);
            LinkedList.LogAll(linkedListExample.Head);
            Console.WriteLine();
            linkedListExample.BubbleSort();
            LinkedList.LogAll(linkedListExample.Head);
        }
    }
}
