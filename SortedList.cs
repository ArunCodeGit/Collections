using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class SortedList
    {
        public static void MySortedList()
        {
            //A sorted list is a combination of an array and a hash table.
            //It contains a list of items that can be accessed using a key or an index.
            //If you access items using an index, it is an ArrayList, and if you access items using a key, it is a Hashtable.
            //The collection of items is always sorted by the key value.

            SortedList<string, int> ml = new SortedList<string, int>();
            ml.Add("Vadai", 10);
            ml.Add("Poori", 20);
            ml.Add("Idly", 15);
            ml.Add("Dhosai", 30);

            foreach (KeyValuePair<string, int> item in ml)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

            //Associate Array using keys to access array elements rather than using index positions.
            int amt = ml["idly"];
            Console.WriteLine(amt);
        }
    }
}
