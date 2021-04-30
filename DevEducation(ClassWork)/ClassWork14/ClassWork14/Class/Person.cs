using System;

namespace ClassWork14
{
    public partial class Person
    {
        protected string Name { get; set; }
        protected int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void ShowMeYouInfo()
        {
            Console.WriteLine($"name: {Name}\t age: {Age} ");
        }
    }
}