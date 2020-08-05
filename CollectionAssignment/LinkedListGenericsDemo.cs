using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class LinkedListGenericsDemo
    {
        static void Main()
        {
            LinkedList<String> myList = new LinkedList<String>();

            // Adding nodes in LinkedList 
            myList.AddLast("THis");
            myList.AddLast("is");
            myList.AddLast("Linked");
            myList.AddLast("List");
            myList.AddFirst("Hello");


            // To check if LinkedList is empty or not 
            if (myList.Count > 0)
                Console.WriteLine("LinkedList is not empty");
            else
                Console.WriteLine("LinkedList is empty");

            foreach (var a in myList)
            {
                Console.WriteLine(a);
            }


            Console.WriteLine("The first value in the list is : ");
            if (myList.Count > 0)
                Console.WriteLine(myList.First.Value);
            else
                Console.WriteLine("LinkedList is empty");

            Console.WriteLine("The last value in the list is :");
            if (myList.Count > 0)
                Console.WriteLine(myList.Last.Value);
            else
                Console.WriteLine("LinkedList is empty");

            Console.WriteLine("The list conatains Hello : {0}", myList.Contains("Hello"));





            Console.WriteLine("After removing first element :");
            myList.Remove(myList.First);
            Console.WriteLine("Total elements in List are : " + myList.Count);

            // Displaying the nodes in LinkedList 
            foreach (var i in myList)
            {
                Console.WriteLine(i);
            }

          



        }
    }
}
    
