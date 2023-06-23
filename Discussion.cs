using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Discussion
    {
        #region List
        public static void ListExercises()
        {
            List<string> MyList = new List<string>();
            LinkedList<string> list = new LinkedList<string>();

            MyList.Add("Arun");
            MyList.Add("Kumar");

            Console.WriteLine("Capacity: "+MyList.Capacity);
            Console.WriteLine("Count: "+MyList.Count);
            MyList.Add("Aravindh");
            MyList.Add("Ravi");
            Console.WriteLine("Capacity: " + MyList.Capacity);
            Console.WriteLine("Count: " + MyList.Count);

            MyList.Insert(1, "Raja");
            MyList.Sort();

            //foreach -  read only loop 
            foreach (string person in MyList)
            {
                Console.WriteLine(person);
            }

            MyList.Remove("Arun");
            if (MyList.Contains("Arun"))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
        #endregion

        #region Sorted List - Key Value
        public static void SortedList()
        {
            //Sorted based on Key

            SortedList<string, int> MyList = new SortedList<string, int>();

            MyList.Add("idly", 20);
            MyList.Add("Vadai", 10);
            MyList.Add("Dosai", 30);
            MyList.Add("Poori", 25);


            //foreach (string key in MyList.Keys)
            //{
            //    Console.WriteLine(key);
            //}

            //foreach (int val in MyList.Values)
            //{
            //    Console.WriteLine(val);
            //}

            //foreach (KeyValuePair<string, int> Item in MyList.Reverse())
            //{
            //    Console.WriteLine(Item.Key + " : " + Item.Value);
            //}

            //associative array

            int amt = MyList["idly"];
            Console.WriteLine(amt);
        }
        #endregion

        #region Queue and Stack
        public static void QueueAndStack()
        {
            //Queue - FIFO | Stack: LIFO

            Queue<string> MyQueue = new Queue<string>();
            MyQueue.Enqueue("Anand"); //Push() for stack
            MyQueue.Enqueue("Kumar");
            MyQueue.Enqueue("Arun");
            MyQueue.Enqueue("Raja");

            Console.WriteLine("Peek: " + MyQueue.Peek);

            Console.WriteLine(MyQueue.Dequeue()); //Pop for stack

            Console.WriteLine("Peek: " + MyQueue.Peek());

            while (MyQueue.Count > 0)
            {
                Console.WriteLine(MyQueue.Dequeue());
            }
        }
        #endregion

        #region Dictionary - Hash Table - Fast
        public static void DictionaryExercise()
        {
            Dictionary<string, int> MyDictionary = new Dictionary<string, int>();
            MyDictionary.Add("Anand", 35);
            MyDictionary.Add("Arun", 23);

            //if key not found, then it will raise an exception
            if (MyDictionary.ContainsKey("Anand1"))
            {
                Console.WriteLine(MyDictionary["Anand1"]);
            }
            else
            {
                MyDictionary.Add("Anand1", 0);
                Console.WriteLine("Not Found, but added now");
            }
            Console.WriteLine(MyDictionary["Anand1"]);
        }
        #endregion
    }
}
