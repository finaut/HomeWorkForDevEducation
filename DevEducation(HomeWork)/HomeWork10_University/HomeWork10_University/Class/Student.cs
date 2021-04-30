using System;

namespace HomeWork10_University.Class
{
    public sealed class Student : Person
    {
        public Student(int course, bool studentStudying,string firstName,
            string lastName, int age, string gender, string location, string faculty) 
            :base(firstName, lastName, age, faculty, gender, location)
        {
            StudentStudying = studentStudying;
            Course = course;
        }
        //
        
        protected override string FirstName { get; set; }
        protected override string LastName { get; set; }
        protected override int Age { get; set; }
        protected override string Faculty { get; set; }
        protected override string Gender { get; set; }
        protected sealed override string Location { get; set; }
        private int Course { get; set; }
        
        public bool StudentStudying { get; set; }
        public override void GiveMyDetails()
        {
            Console.WriteLine($"First name: {FirstName}\n" +
                              $"Last Name: {LastName}\n" +
                              $"Age: {Age}\n" +
                              $"Course: {Course}\n" +
                              $"Faculty: {Faculty}\n" +
                              $"Gender: {Gender}\n" +
                              $"Location: {Location}" +
                              $"Stydi: {StudentStudying}");
            ;
        }
    }
}