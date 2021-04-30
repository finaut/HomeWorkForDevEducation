namespace ConsoleApplication1.University.interfaces
{
    public interface IStudentPresentService
    {
        void AddPresentStudent(IPerson person);
        int GetAllCountPresentStudents();
        double GetAllCountStudents();
    }
}