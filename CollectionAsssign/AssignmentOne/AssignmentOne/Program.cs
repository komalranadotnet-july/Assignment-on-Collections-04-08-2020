using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Person
    {
        public int age;
        public string fname;
        public string lname;
        public string city;

        public Person()
        {

        }

        public Person(int _age,string _fname,string _lname,string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;
        }

        public void Display()
        {
            Console.WriteLine("The age of person is : {0}",age);
            Console.WriteLine("The First name of Person is : {0}",fname);
            Console.WriteLine("The Last name of Person is : {0}", lname);
            Console.WriteLine("The City of Person is : {0}", city);


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Persons = new List<Person>();
            Person p1 = new Person(20,"abc","xyz","Pune");
            Person p2 = new Person(21, "bc", "yz", "Gurgaon");
            Person p3 = new Person(22, "komal", "rana", "Palampur");
            Person p4 = new Person(23, "ab", "xy", "Shimla");
            Person p5 = new Person(22, "a", "b", "Manali");

            Persons.Add(p1);
            Persons.Add(p2);
            Persons.Add(p3);
            Persons.Add(p4);
            Persons.Add(p5);



            foreach (var p in Persons)
            {
                Console.WriteLine("----------------------------");
                p.Display();
            }

        }
    }
}
