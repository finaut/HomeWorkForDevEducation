using ConsoleApplication1.LilaFryLove.Implimatetion;
using ConsoleApplication1.LilaFryLove.Interfaces;
using ConsoleApplication1.University.implementation;
using ConsoleApplication1.University.interfaces;
using Moq;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private ILila _lila;
        private Mock<IFray> _fryMock;
        private ITeacher _teacher;
        private Mock<IStudentPresentService> _sps;
        [SetUp]
        public void Setup()
        {
            _lila = new Lila();
            _fryMock = new Mock<IFray>(MockBehavior.Strict);
            _lila.FrayPerson = _fryMock.Object;
            _sps = new Mock<IStudentPresentService>(MockBehavior.Strict);
            _teacher = new Teacher(_sps.Object);
        }
        
        // [Test]
        // public void TestFrayStupid()
        // {
        //     _fryMock.Setup(a => a.BeStupid());
        //     _lila.LoveZep();
        //     _fryMock.Verify(a => a.BeStupid(), Times.Once);
        // }
        [Test]
        public void TestFrayLoveLila()
        {
            _fryMock.Setup(a => a.LoveLila(It.IsAny<string>()));
            _fryMock.Setup(a => a.BeStupid());
            _lila.LoveFry();
            _fryMock.Verify(a => a.LoveLila(It.IsAny<string>()), Times.Once);
            _fryMock.Verify( a => a.BeStupid(), Times.Once);
        }

        [Test]
        public void TestTeacher()
        {
            _sps.Setup(a => a.AddPresentStudent(It.IsAny<IPerson>()));
            _teacher.AddPresentStudent(It.IsAny<IPerson>());
            _sps.Verify(a => a.AddPresentStudent(It.IsAny<IPerson>()), Times.Once);
        }

        [Test]
        public void GetAllCountPresentStudentsTest()
        {
            var count = 15;
            _sps.Setup(a => a.GetAllCountPresentStudents()).Returns(count);
            _teacher.GetAllCountPresentStudents();
        }

        [Test]
        public void GetAllCountStudentTest()
        {
            var presentCount = 5;
            var allCount = 15;
            _sps.Setup(a => a.GetAllCountPresentStudents()).Returns(presentCount);
            _sps.Setup(a => a.GetAllCountStudents()).Returns(allCount);
            var res = _teacher.GetAllCountPresentStudents();
            
            _sps.Verify( a => a.GetAllCountPresentStudents(),  Times.Once);
            _sps.Verify(a =>  a.GetAllCountStudents(), Times.Once());
        }
    }
}