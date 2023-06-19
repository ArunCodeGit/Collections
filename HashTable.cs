using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    public class HashTableExercise
    {
        //It optimizes lookups by computing the hash code of each key and stores it in a different bucket internally and
        //then matches the hash code of the specified key at the time of accessing values.
        //Hashtable stores key-value pairs.
        //Keys must be unique and cannnot be null.
        //Values can be null or duplicate.
        //Values can be accessed by passing associated key in the indexer e.g. myHashtable[key]


        public static void MyHashtable()
        {
            Hashtable table = new Hashtable();
            table.Add("Emp_Name", "Arunkumar");
            table.Add("Emp_Id", 1001);
            table.Add("Role", "Software Engineer");
            table.Add("Department", "Development");
            table.Add("Product", "Bold BI");
            table.Add("Salary", 21000);
            table.Add("Age", 25);

            Console.WriteLine("Hello".GetHashCode());

            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine(item.Key +": "+item.Value);
            }


            //creating a Hashtable using collection-initializer syntax
            var Cities = new Hashtable()
            {
                {"UK", "London, Manchestar, Birmingham"},
                {"USA", "Chicago, New york, Washington" },
                {"India", "Mumbai, New Delhi, Tamil Nadu" }
            };

            //Cast to string
            string CitiesOfIndia = (string)Cities["India"];

            Console.WriteLine(CitiesOfIndia);

            //Update value of India key

            Cities["India"] = "Kerala, Pondy";
            Cities["USA"] = "Los Angeles";

            if(!Cities.ContainsKey("France"))
            {
                Cities["France"] = "Paris";
            }

            foreach(DictionaryEntry City in Cities)
            {
                Console.WriteLine(City.Key+": "+City.Value);
            }


            //Remove Elements from Hashtable

            Cities.Remove("UK");

            if(Cities.ContainsKey("France"))   // check key before removing it
            {
                Cities.Remove("France");
            }

            Cities.Clear();    //Removes all elements
        }
    }
}
