using System;
using System.Collections.Generic;

namespace ClassWork14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person2 person1 = new Person2("Danil");
            Person2 person2 = new Person2("Egor");
            Person2 person3 = new Person2("Yana");
            
            LinkedList<Person2> list = new LinkedList<Person2>();
            
            var node1 = list.AddLast(person1);
            var node2 = list.AddLast(person2);
            var node3 = list.AddLast(person3);

            

        }
    }

    public class Person2
    {
        private string Name { get; set; }

        public Person2(string name)
        {
            Name = name;
        }
    }
}