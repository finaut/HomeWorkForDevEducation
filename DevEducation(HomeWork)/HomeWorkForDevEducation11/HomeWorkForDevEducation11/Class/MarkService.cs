using HomeWorkForDevEducation11.Interfaces;

namespace HomeWorkForDevEducation11.Class
{
    public class MarkService : IMarkService
    {
        private int[] _marks = {10, 8, 9, 7, 9, 6, 10, 9, 10, 8};

        public int[] GetAllMarks(IPerson person)
        {
            return _marks;
        }
    }
}