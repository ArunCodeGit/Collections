using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class MyArrayList
    {
        public static void ArrayList()
        {
            //In C#, the ArrayList is a non-generic collection of objects whose size increases dynamically.
            //It is the same as Array except that its size increases dynamically.

            //An ArrayList can be used to add unknown data where you don't know the types and the size of the data.

            ArrayList list = new ArrayList();
            list.Add(1000);
            foreach (object obj in list)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            list.Add(2000);
            list.Add(3000);
            list.Add(4000);
            list.Add(null);
            foreach (object obj in list)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            list.Add(5000);
            foreach (object obj in list)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            //Insert a value index position of 3
            list.Insert(3, 3500);
            foreach (object obj in list)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            //Remove a indices values
            list.Remove(4000);

            //Remove a indices value in the given index position
            //list.RemoveAt(1);
            foreach (object obj in list)
            {
                Console.Write(obj + " ");
            }

            //Use the AddRange(ICollection c) method to add an entire Array, HashTable, SortedList, ArrayList, BitArray, Queue, and Stack in the ArrayList.
            //Adding Entire Array/ArrayList into ArrayList
            var list1 = new ArrayList();
            var list2 = new ArrayList
            {
                1, "Arun", " ", true, 4.5, null
            };

            int[] arr = { 100, 200, 300 };

            Queue<string> MyQ = new Queue<string>();
            MyQ.Enqueue("a");
            MyQ.Enqueue("b");

            list1.AddRange(list2);  //Adding ArrayList in an ArrayList
            list1.AddRange(arr);   //Adding Array in an ArrayList
            list1.AddRange(MyQ);   //Adding Queue in an ArrayList
        }
    }
}
