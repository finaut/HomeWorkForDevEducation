namespace HomeWork10_University.Class
{
    public abstract class Person
    {
        protected abstract string FirstName { get; set; }
        protected abstract string LastName { get; set; }
        protected abstract int Age { get; set; }
        protected abstract string Faculty { get; set; }
        protected abstract string Gender { get; set; }
        protected abstract string Location { get; set; }
        public abstract void GiveMyDetails();

        public Person(string firstName, string lastName, int age, string faculty, string gender, string location)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Faculty = faculty;
            Gender = gender;
            Location = location;
        }
    }
}