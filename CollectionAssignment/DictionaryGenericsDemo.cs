using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class DictionaryGenericsDemo
    {
        static void Main()
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            Console.WriteLine("Elements in the dictionary : ");
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }


            string result;

            if (dict.TryGetValue(4, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Could not find the specified key.");
            }


            Console.WriteLine("Dictionary contains key : {0}",dict.ContainsKey(1));

            Console.WriteLine("Dictionary elements after removing");
            Console.WriteLine(dict.Remove(1));
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }


        }
    }
}
