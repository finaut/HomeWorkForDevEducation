using ConsoleApplication1.University.interfaces;

namespace ConsoleApplication1.University.implementation
{
    public class Teacher : ITeacher
    {
        private IStudentPresentService _studentPresentService;
        public Teacher(IStudentPresentService studentPresentService)
        {
            _studentPresentService = studentPresentService;
        }
        
        public void AddPresentStudent(IPerson person)
        {
            _studentPresentService.AddPresentStudent(person);

        }

        public int  GetAllCountPresentStudents()
        {
            var res = _studentPresentService.GetAllCountPresentStudents();
            return res;
        }

        public double GetAllCountStudent()
        {
            var presentStudent = (double) _studentPresentService.GetAllCountPresentStudents();
            var allStudent = (double) _studentPresentService.GetAllCountStudents();
            var res = presentStudent / allStudent;
            return res * 100;
        }
    }
}