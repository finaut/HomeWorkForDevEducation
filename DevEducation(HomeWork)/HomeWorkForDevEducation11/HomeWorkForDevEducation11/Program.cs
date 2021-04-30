using System;
using HomeWorkForDevEducation11.Class;
using HomeWorkForDevEducation11.Interfaces;

namespace HomeWorkForDevEducation11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPerson person = new Person();
            IMarkService mark = new MarkService();
            IStudent student = new Student();
            Console.WriteLine(student.CheckMark(person));
            
        }
    }
}