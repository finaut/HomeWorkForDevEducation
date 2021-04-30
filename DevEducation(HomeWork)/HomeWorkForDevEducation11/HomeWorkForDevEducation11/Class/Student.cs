using System;
using HomeWorkForDevEducation11.Interfaces;

namespace HomeWorkForDevEducation11.Class
{
    public class Student : MarkService, IStudent
    {
        public IMarkService MarkService { get; set; }

        public string CheckMark(IPerson person)
        {
            int[] marks = MarkService.GetAllMarks(person);
            int sumAllMarks = 0;
            foreach (int i in marks)
                 sumAllMarks += i;
            if ( marks.Length == 0)
            {
                throw new Exception("Error: There are no marks in the journal.");
            }
            else if ((sumAllMarks / marks.Length) >= 7)
            {
                return "Great job";
            }
            else
            {
                return "Bed job";
            }
        }
    }
}