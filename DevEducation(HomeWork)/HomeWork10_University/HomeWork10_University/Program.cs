using HomeWork10_University.Class;

namespace HomeWork10_University
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student(4, true, "Albert", "Albertovich", 89, "man",  "Dnipro","compute programming");
            Dean dean = new Dean("Danil", "Novikov", 21, "Computer", "man", "Dnipro", 4, 3, true);
            Lecturer lecturer = new Lecturer("Aust", "Fin", 32, "Computer", "man", "Dnipro", 2, 5, true);
            Rector rector = new Rector("Octer", "Maus", 45, "Computer", "woman", "Odessa", 1, 21, true);
            
            lecturer.LeadLection();
            lecturer.GiveMyDetails();
            dean.DismissLecturer(lecturer);
            lecturer.GiveMyDetails();

            student.GiveMyDetails();
            dean.ExpelStudent(student);
            student.GiveMyDetails();

            rector.DismissDean(dean);
            dean.GiveMyDetails();
        }
    }
}