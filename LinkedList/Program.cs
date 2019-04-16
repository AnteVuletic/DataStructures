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
            linkedListExample.Push("Test");
            linkedListExample.Push("Test 1");
            linkedListExample.Push("Test 2");
            linkedListExample.Push("Test 3");
            LinkedList.LogAll(linkedListExample.Head);
        }
    }
}
