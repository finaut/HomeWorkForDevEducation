using System;
using HomeWork10_University.Interfaces;

namespace HomeWork10_University.Class
{
    public sealed class Dean : Employee, IDean
    {
        public Dean(string firstName, string lastName, int age,
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

        
        public void ExpelStudent(Student student)
        {
            if (student.StudentStudying == true)
            {
                student.StudentStudying = false;
                student.GiveMyDetails();
                Console.WriteLine("---------------------------");
                Console.WriteLine("But I had to go to lectures.");
            }
            else
            {
                student.GiveMyDetails();
                Console.WriteLine("---------------------------");
                Console.WriteLine("unfortunately the state did not have money for his education.");
            }
        }

        public void DismissLecturer(Lecturer lecturer)
        {
            if (lecturer.WorkToDay == true)
            {
                lecturer.WorkToDay = false;
                lecturer.GiveMyDetails();
                Console.WriteLine("--------------------------");
                Console.WriteLine("He won't work here anymore");
            }
            else
            {
                lecturer.GiveMyDetails();
                Console.WriteLine("------------------------");
                Console.WriteLine("He is already unemployed");
            }
        }
    }
}