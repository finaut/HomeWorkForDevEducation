using LessonMoq.University.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LessonMoq.University.Implementation
{
    public class Teacher : ITeacher
    {
        private IStudentPresentService _studentPresentService;
        public Teacher(IStudentPresentService studentPresentService)
        {
            _studentPresentService = studentPresentService ?? throw new ArgumentNullException();
        }

        public void AddPresentStudent(IPerson person)
        {
            if (person == null)
            {
                return;
            }
            _studentPresentService.AddPresentStudent(person);

        }

        public int GetAllcountPresentstudents()
        {
           var res = _studentPresentService.GetAllcountPresentstudents();
           return res ;
        }

        public double GetPersentPresentStudent()
        {
            var presentStudent = (double) _studentPresentService.GetAllcountPresentstudents();
            var allStudents = (double) _studentPresentService.GetAllCountStudents();
            var res = presentStudent / allStudents;
            return res * 100;
        }
    }
}
