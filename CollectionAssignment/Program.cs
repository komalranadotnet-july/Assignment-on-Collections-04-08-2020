using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sList = new SortedList<int, string>();

            sList.Add(3, "Sorted");
            sList.Add(4, "List");
            sList.Add(2, "is");
            sList.Add(1, "This");
            Console.WriteLine("Elemnents in Sorted List :");
            foreach (KeyValuePair<int, string> item in sList)
            {

                Console.WriteLine("Key {0}, Value {1}", item.Key, item.Value);

            }

            Console.WriteLine("******Access Elements with Key, Index Position*****");

            // Access value with key
            string val1 = sList[2];  // Access value with key
            Console.WriteLine("Value at Key '2': " + val1);


            string val2 = sList.Values[2]; // Access value with index position
            Console.WriteLine("Value at Index '2': " + val2);


            int val3 = sList.Keys[2];  // Access key with index position

            Console.WriteLine("Key at Index '2': " + val3);


            Console.WriteLine("Output for contains key and value");
            if (sList.ContainsKey(4))
            {
                Console.WriteLine("The key is there in Sorted List");
            }
            else
            {
                Console.WriteLine("Key is not in sorted list ");
            }

            if (sList.ContainsValue("hello"))
            {
                Console.WriteLine("The value is there in Sorted List");
            }
            else
            {
                Console.WriteLine("Value is not in sorted list ");
            }

            Console.WriteLine("Number of key-value in Sorted List :  {0}", sList.Count);


            // Using Remove() method 
            Console.WriteLine("After removing");
            sList.Remove(4);
            foreach (KeyValuePair<int, string> item in sList)
            {

                Console.WriteLine(" {0},  {1}", item.Key, item.Value);

            }

            // Remove element at index 2 
            // Using RemoveAt() method 
            Console.WriteLine("After removing at given index");

            sList.RemoveAt(2);
            foreach (KeyValuePair<int, string> item in sList)
            {

                Console.WriteLine(" {0},  {1}", item.Key, item.Value);

            }
            sList.Clear();
            Console.WriteLine("The total number of key/value pairs  present in sorted list:{0}", sList.Count);

        }
    }
}
