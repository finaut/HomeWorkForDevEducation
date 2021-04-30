using System;
using System.Collections.Generic;
using System.Text;

namespace LessonMoq.University.Interfaces
{
    public interface IStudentPresentService
    {
        void AddPresentStudent(IPerson person);
        int GetAllcountPresentstudents();
        int GetAllCountStudents();
    }
}
