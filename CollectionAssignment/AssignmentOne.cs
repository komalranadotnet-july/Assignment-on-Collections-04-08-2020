using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class AssignmentOne
    {
        static void Main()
        {
            LinkedList<string> lList = new LinkedList<string>(new string[]
           {"quick","fox","the","lazy"});
            foreach (var a in lList)
            {
                Console.WriteLine(a);
            }


            Console.WriteLine("----------------");
            lList.AddFirst("the");
            foreach (var a in lList)
            {
                Console.WriteLine(a);
            }

          Console.WriteLine("----------------");
            lList.AddLast("fox");
            foreach (var a in lList)
            {
                Console.WriteLine(a);
            }


            


        }
    }
}
