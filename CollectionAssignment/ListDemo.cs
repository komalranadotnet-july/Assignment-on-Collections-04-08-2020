using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class ListDemo
    {
        static void Main()
        {
            
        var list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(700);
            list.Add(0);

            Console.WriteLine( "----Find Index-----");
            // Find index of element 100 or greater.
            int result = list.FindIndex(element => element >= 100);
        Console.WriteLine("Result of FindIndex: {0}", result);

            Console.WriteLine("-----Find Last-------");
            //Find Last
            int result1 = list.FindLast(item => item > 20);
            Console.WriteLine("Result of FindLast: {0}", result);


            Console.WriteLine("------Find All--------");

            var list1 = new List<string>() { "bird", "frog", "ball", "leaf" };

            // Invoke FindAll info reach.
            // ... FindAll is only invoked once for the entire loop.
            foreach (string value in list1.FindAll(element => element.StartsWith("b")))
            {
                Console.WriteLine("FindAll StartsWith B: {0}", value);
            }




        }
    }
}
