using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class List
    {
        public static void MyList()
        {
            //List is a data structure that stores elements in an ordered and sequential manner.
            //A list can store repetitive elements which means a single element can occur more than once in a list.

            List<string> ml = new List<string>(3);
            ml.Add("Arun");
            ml.Add("Kumar");

            string x = "";
            foreach (string person in ml)
            {
                x += person + "\t";
            }
            Console.WriteLine(x);

            ml.Add("Murali");
            ml.Add("Mani");

            ml.Insert(2, "Raja");
            ml.Remove("Arun");
            ml.Sort();
            if (ml.Contains("Arun"))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            Console.WriteLine(ml.ElementAt(2));
        }
    }
}
