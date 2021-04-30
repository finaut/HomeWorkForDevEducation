using System;
using System.Linq;
using HomeWorkForDevEducation11.Interfaces;

namespace HomeWorkForDevEducation11.Class
{
    public class Teacher : MarkService, ITeacher
    {
        public IMarkService MarkService { get; set; }
        
        public double GetAverage(IPerson person)
        { 
            int[] marks = MarkService.GetAllMarks(person);
            double sumAllMarks = 0;
            if (marks.Length == 0)
            {
                return 0;
                // throw new Exception("Error: There are no marks in the journal.");
            }
            for (int i = 0; i < marks.Length; i++)
            {
                sumAllMarks += marks[i];
            }
            // 10 - потому что максимальная оценка 10;
            return (sumAllMarks / (marks.Length * 10) * 100);
        }

        public int GetLastMark(IPerson person)
        {
            int[] marks = MarkService.GetAllMarks(person);
            int lastMark = marks[marks.Length - 1];
            return lastMark;
        }
    }
}