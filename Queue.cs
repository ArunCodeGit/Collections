using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Queue
    {
        public static void MyQueue()
        {
            //A queue can be defined as an ordered list which enables insert operations to be performed at one end called REAR and
            //delete operations to be performed at another end called FRONT.


            Queue<string> mq = new Queue<string>();
            mq.Enqueue("Arun");
            mq.Enqueue("Kumar");

            mq.Enqueue("Murali");
            mq.Enqueue("Dharan");

            Console.WriteLine(mq.Dequeue());
            Console.WriteLine(mq.Dequeue());
            Console.WriteLine(mq.Peek() + " is peek view");

            while (mq.Count > 0)
            {
                Console.WriteLine(mq.Dequeue());
            }
        }
    }
}
