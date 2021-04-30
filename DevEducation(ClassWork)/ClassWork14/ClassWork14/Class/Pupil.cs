using System;
using Microsoft.SqlServer.Server;

namespace ClassWork14
{
    public class Pupil : Person
    {
        public string Form { get; set; }
        public Pupil(string name, int age, string form) : base(name, age)
        {
            Form = form;
        }

        public override void ShowMeYouInfo()
        {
            Console.WriteLine($"Name: {Name}\t Age: {Age}\t Form: {Form}");
        }
    }
}