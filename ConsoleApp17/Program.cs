using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedList<int, Person> sortedPersoner = new SortedList<int, Person>();
            Dictionary<int, Person> dicPersoner = new Dictionary<int, Person>();
            List<Person> dp = new List<Person>(dicPersoner.Values);
            dp.Sort();


            List<Person> psoriginal = new List<Person>()
            {
                new Person(5, "Peter"),
                new Person(3, "Jakob"),
                new Person(14, "Charlotte"),
                new Person(6, "Anders"),
                new Person(4, "Zuhair")
            };

            UdskrivList(psoriginal);

            // laver en kopi af listen
            List<Person> ps = new List<Person>(psoriginal);

            ps.Sort(new PersonSorterId());

            Console.WriteLine("Sort ID");
            UdskrivList(ps);

            ps.Sort(new PersonSorterName());
            Console.WriteLine("Sort Name");
            UdskrivList(ps);


            Console.WriteLine("Den originale liste");
            UdskrivList(psoriginal);

            Console.WriteLine("Hello World!");
        }

        private static void UdskrivList(List<Person> ps)
        {
            foreach (Person p in ps)
            {
                Console.WriteLine(p);
            }
        }
    }


    class Person
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
    }

    class PersonSorterId : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Id - y.Id;
        }
    }

    class PersonSorterName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }


}
