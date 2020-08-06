using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class AssignmentOne
    {
        static void Main()
        {
            LinkedList<string> lList = new LinkedList<string>(new string[] {"quick","fox","the","lazy"});

            lList.AddFirst("the");
            lList.AddLast("fox");

            foreach (var item in lList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            LinkedListNode<string> current = lList.FindLast("quick");
             lList.AddAfter(current, "brown");


            LinkedListNode<string> current1 = lList.FindLast("the");
            lList.AddBefore(current1, "jumps");

            LinkedListNode<string> current2 = lList.FindLast("jumps");
            lList.AddAfter(current2, "over");


            foreach (var item in lList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
   