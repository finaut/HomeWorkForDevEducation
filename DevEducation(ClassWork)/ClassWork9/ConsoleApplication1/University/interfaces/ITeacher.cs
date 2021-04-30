namespace ConsoleApplication1.University.interfaces
{
    public interface ITeacher
    {
        void AddPresentStudent(IPerson person);
        int GetAllCountPresentStudents();
        double GetAllCountStudent();

    }
}