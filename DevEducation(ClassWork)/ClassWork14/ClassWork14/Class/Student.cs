using System;
using System.Data.SqlTypes;

namespace ClassWork14
{
    public class Student : Person
    {
        public string HeighShoolName { get; set; }
        public Student(string name, int age,  string heighShoolName) : base(name, age)
        {
            HeighShoolName = heighShoolName;
        }

        public override void ShowMeYouInfo()
        {
            Console.WriteLine($"name: {Name}\t age: {Age}\t hsName: {HeighShoolName}");
        }
    }
}