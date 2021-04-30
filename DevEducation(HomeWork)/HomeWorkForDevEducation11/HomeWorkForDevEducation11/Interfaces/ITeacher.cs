using HomeWorkForDevEducation11.Class;

namespace HomeWorkForDevEducation11.Interfaces
{
    public interface ITeacher
    {
        IMarkService MarkService { get; set; }
        double GetAverage(IPerson person);
        int GetLastMark(IPerson person);
    }
}