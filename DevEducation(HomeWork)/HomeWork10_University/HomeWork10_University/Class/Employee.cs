using System;

namespace HomeWork10_University.Class
{
    public class Employee : Person
    {   
        protected int QuatityDisciplines { get; set; }
        protected int WorkExperience { get; set; }
        public bool WorkToDay { get; set; }
        protected override string FirstName { get; set; }
        protected override string LastName { get; set; }
        protected override int Age { get; set; }
        protected override string Faculty { get; set; }
        protected override string Gender { get; set; }
        protected override string Location { get; set; }

        public Employee( int quatityDisciplines, int workExperience, bool workToDay, string firstName, string lastName, int age, string faculty, string gender, string location )
            :base(firstName, lastName, age, faculty, gender, location )
        {
            QuatityDisciplines = quatityDisciplines;
            WorkExperience = workExperience;
            WorkToDay = workToDay;
        }
        
        public override void GiveMyDetails()
        {
            Console.WriteLine($"First name: {FirstName}\n" +
                              $"Last Name: {LastName}\n" +
                              $"Age: {Age}\n" +
                              $"Faculty: {Faculty}\n" +
                              $"Gender: {Gender}\n" +
                              $"Location: {Location}" +
                              $"Quatity discliplines: {QuatityDisciplines}\n" +
                              $"Work: {WorkExperience}\n" +
                              $"Work to day?: {WorkToDay}");
        }
    }
}