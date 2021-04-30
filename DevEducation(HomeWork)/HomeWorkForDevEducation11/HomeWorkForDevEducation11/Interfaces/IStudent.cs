using HomeWorkForDevEducation11.Class;

namespace HomeWorkForDevEducation11.Interfaces
{
    public interface IStudent
    {
        IMarkService MarkService { get; set; }
        string CheckMark(IPerson person);
    }
}