using System;
using HomeWork10_University.Interfaces;

namespace HomeWork10_University.Class
{
    public sealed class Lecturer : Employee, ILecturer
    {
        public Lecturer(string firstName, string lastName, int age,
            string faculty, string gender, string location,
            int quatityDisciplines, int workExperience, bool workToDay) 
            : base(quatityDisciplines, workExperience,
                workToDay, firstName, lastName, age, faculty,
                gender, location)
        {
            
        }
        protected override string FirstName { get; set; }
        protected override string LastName { get; set; }
        protected override int Age { get; set; }
        protected override string Faculty { get; set; }
        protected override string Gender { get; set; }
        protected override string Location { get; set; }
        
        public void LeadLection()
        {
            Console.WriteLine("bla bla bla. The lecture is over.");
        }
    }
}