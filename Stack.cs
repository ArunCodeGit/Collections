using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Stack
    {
        public static void MyStack()
        {
            //Stacks in Data Structures is a linear type of data structure that follows the LIFO (Last-In-First-Out) principle and
            //allows insertion and deletion operations from one end of the stack data structure, that is top.

            Stack<string> ms = new Stack<string>();
            ms.Push("Arun");
            ms.Push("Kumar");
            ms.Push("Mani");
            ms.Push("Bharathi");

            Console.WriteLine(ms.Peek());
            Console.WriteLine(ms.Pop());

            while (ms.Count > 0)
            {
                Console.WriteLine(ms.Pop());
            }
        }
    }
}
