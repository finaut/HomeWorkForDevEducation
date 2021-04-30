using System;
using System.Collections.Generic;
using System.Text;

namespace LessonMoq.University.Interfaces
{
    public interface ITeacher
    {
        void AddPresentStudent(IPerson person);
        int GetAllcountPresentstudents();

        double GetPersentPresentStudent();
    }
}
