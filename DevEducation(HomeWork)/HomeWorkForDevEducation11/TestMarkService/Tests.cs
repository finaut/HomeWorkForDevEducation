using System;
using System.Linq;
using System.Runtime.Versioning;
using HomeWorkForDevEducation11.Class;
using HomeWorkForDevEducation11.Interfaces;
using Moq;
using NUnit.Framework;

namespace TestMarkService
{
    [TestFixture]
    public class Tests
    {
        private ITeacher _teacher;
        private Mock<IMarkService> _markService;
        private IPerson person = new Person();
        private int[] _marks = {10, 8, 9, 7, 9, 6, 10, 9, 10, 8};
        private IStudent _student;

        [SetUp]
        public void Setup()
        {
            _student = new Student();
            _teacher = new Teacher();
            _markService = new Mock<IMarkService>(MockBehavior.Loose);
            _teacher.MarkService = _markService.Object;
            _student.MarkService = _markService.Object;
        }

        [Test]
        public void StudentTestGet()
        {
            _markService.Setup(a => a.GetAllMarks(person)).Returns(_marks);
            string resultStudent = _student.CheckMark(person);
            _markService.Verify(a => a.GetAllMarks(person), Times.Once);
            Assert.AreEqual("Great job", resultStudent);
        }
        
        [Test]
        public void TeacherTestGetLastMark()
        {
            _markService.Setup(a => a.GetAllMarks(person)).Returns(_marks);
            int lastMark = _teacher.GetLastMark(person);
            _markService.Verify(a => a.GetAllMarks(person), Times.Once);
            Assert.AreEqual(8, lastMark);
        }

        [Test]
        public void TeacherTestGetAverage()
        {
            _markService.Setup(a => a.GetAllMarks(person)).Returns(_marks);
            double percentAverage = _teacher.GetAverage(person);
            _markService.Verify(a => a.GetAllMarks(person), Times.Once);
            Assert.AreEqual(86.0, percentAverage);
        }
    }
}
