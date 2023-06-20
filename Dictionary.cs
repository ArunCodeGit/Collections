using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Dictionary
    {
        public static void MyDictionary()
        {
            //A dictionary is a general-purpose data structure for storing a group of objects. •
            //A dictionary has a set of keys and each key has a single associated value.

            Dictionary<string, int> Mydict = new Dictionary<string, int>();
            Mydict.Add("Vadai", 10);
            Mydict.Add("Poori", 25);
            Mydict.Add("Dhosai", 35);
            Mydict.Add("Tea", 8);

            int Cost = 0;

            //Mydict.Remove("Dhosai");

            if (Mydict["Dhosai"] == 35)
            {
                Console.WriteLine("True");
            }

            if (Mydict.TryGetValue("Dhosai", out Cost))
            {
                Console.WriteLine(Cost);
                if (Cost == 35)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }

            // do not use - always use TryGetValue
            Console.WriteLine(Mydict["Vadai"]);
            foreach (KeyValuePair<string, int> item in Mydict)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
