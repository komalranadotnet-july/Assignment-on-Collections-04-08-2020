using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class ArrayListDemo
    {
        static void Main()
        {
            ArrayList arr = new ArrayList();
            arr.Add(5);
            arr.Add(6);
            arr.Add(7);
            arr.Add(8);
            arr.Add(9);


           Console.WriteLine("Elements of ArrayList");
            foreach (var r in arr)//arr has to implement IEnmerable
            {
                Console.WriteLine(r);
            }


            Console.WriteLine("Count  of array list: " + arr.Count);

            Console.WriteLine("Index of 8 is : {0}", arr.IndexOf(8));

            arr.Reverse();
            Console.WriteLine("Array after Reversing");
            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }

            arr.Sort();
            Console.WriteLine("Array after sorting");
            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }





            arr.InsertRange(3, new int[] { 34, 35, 36, 37, 38 });
            Console.WriteLine("Inserting a range of values at index 3");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }



           
            ArrayList getRange = arr.GetRange(1, 4);
            Console.WriteLine("Range of elements are :");
            foreach (var a in getRange)
            {
                Console.WriteLine(a);
            }



            Console.WriteLine("The elements in ArrayList initially are :");

            foreach (var s in arr)
                Console.WriteLine(s);




            arr.RemoveAt(4);

            // Displaying the elements in ArrayList 
            Console.WriteLine("The elements in ArrayList after RemoveAt :");

            foreach (var s in arr)
                Console.WriteLine(s);




            arr.Remove("35");
            Console.WriteLine("ArrayList after removing an element...");

            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }

            arr.RemoveRange(2, 2);

            // Displaying the modified ArrayList 
            Console.WriteLine("The ArrayList after Removing elements for range: ");

            // Displaying the elements in ArrayList 
            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Array after Insert:");
            arr.Insert(1, 20);
            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("The array list conatains 20 : {0}",arr.Contains(20));


            arr.Clear();
            // after Removing all the elements 
            Console.WriteLine("Number of elements in ArrayList : " + arr.Count);
          
        }
    }









}
    

