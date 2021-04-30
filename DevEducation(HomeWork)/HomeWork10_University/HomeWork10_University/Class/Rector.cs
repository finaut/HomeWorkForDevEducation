using System;
using HomeWork10_University.Interfaces;

namespace HomeWork10_University.Class
{
    public sealed class Rector : Employee, IRector
    {
        public Rector(string firstName, string lastName, int age,
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
        
        public void DismissDean(Dean dean)
        {
            if (dean.WorkToDay == true)
            {
                dean.WorkToDay = false;
                dean.GiveMyDetails();
                Console.WriteLine("--------------------------");
                Console.WriteLine("He won't work here anymore");
            }
            else
            {
                dean.GiveMyDetails();
                Console.WriteLine("------------------------");
                Console.WriteLine("He is already unemployed");
            }
        }
    }
}