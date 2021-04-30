using LessonMoq.University.Implementation;
using LessonMoq.University.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit.LessonMoq
{
    public class TeacherTests
    {
        private ITeacher _teacher;
        private Mock<IStudentPresentService> _sps;
        [SetUp]
        public void SetUp()
        {
            _sps = new Mock<IStudentPresentService>(MockBehavior.Strict);
            _teacher = new Teacher(_sps.Object);
        }

        [Test]
        public void TeacherNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _teacher = new Teacher(null);
            });
        }

        [Test]
        public void AddPresentStudentTest()
        {
            _sps.Setup(a => a.AddPresentStudent(It.IsAny<IPerson>()));
            _teacher.AddPresentStudent(It.IsAny<IPerson>());
            _sps.Verify(a => a.AddPresentStudent(It.IsAny<IPerson>()), Times.Once);
        }

        [Test]
        public void AddPresentStudentTest_2()
        {
            _sps.Setup(a => a.AddPresentStudent(It.IsAny<IPerson>()));
            _teacher.AddPresentStudent(null);
            _sps.Verify(a => a.AddPresentStudent(It.IsAny<IPerson>()), Times.Never);
        }

        [Test]
        public void GetAllcountPresentstudentsTest()
        {
           // var count = 15;
            _sps.Setup(a => a.GetAllcountPresentstudents()).Returns(It.IsAny<int>);
            _teacher.GetAllcountPresentstudents();
            _sps.Verify(a => a.GetAllcountPresentstudents(), Times.Once);
        }

        [Test]
        public void GetAllcountPresentstudentsTest_2()
        {
             var count = 15;
            _sps.Setup(a => a.GetAllcountPresentstudents()).Returns(count);
            var res = _teacher.GetAllcountPresentstudents();

            Assert.AreEqual(count, res);
        }

        [Test]
        public void GetPersentPresentStudentTest()
        {
            var presentcount = 5;
            var allCount = 15;
            _sps.Setup(a => a.GetAllcountPresentstudents()).Returns(presentcount);
            _sps.Setup(a => a.GetAllCountStudents()).Returns(allCount);

            var res = _teacher.GetPersentPresentStudent();

            _sps.Verify(a => a.GetAllcountPresentstudents(), Times.Once);
            _sps.Verify(a => a.GetAllCountStudents(), Times.Once);

            var exp = 33.33;
            Assert.AreEqual(exp, res, 0.01);
        }
    }
}
