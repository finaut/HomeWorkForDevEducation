using LessonMoq.LilaFrylove.Implementation;
using LessonMoq.LilaFrylove.Interfaces;
using Moq;
using NUnit.Framework;

namespace NUnit.LessonMoq
{
    public class LilaTests
    {
        private ILila _lila;
        private Mock<IFry> _fryMock;

        [SetUp]
        public void Setup()
        {
            _lila = new Lila();
            _fryMock = new Mock<IFry>(MockBehavior.Strict);
            _lila.Fry = _fryMock.Object;
        }

        [Test]
        public void LoveZepTest()
        {
            _fryMock.Setup(a => a.BeStupid());
            _lila.LoveZep();
            _fryMock.Verify(a => a.BeStupid(), Times.Once);
        }

        //[Test]
        //public void LoveFryTest()
        //{
        //    _fryMock.Setup(a => a.LoveLila(It.IsAny<string>()));

        //    _lila.LoveFry();

        //    _fryMock.Verify(a => a.LoveLila(It.IsAny<string>()), Times.Once);
        //}

        [Test]
        public void LoveFryTest_2()
        {
            _fryMock.Setup(a => a.LoveLila(It.IsAny<string>()));
            _fryMock.Setup(a => a.BeStupid());

            _lila.LoveFry();

            _fryMock.Verify(a => a.LoveLila(It.IsAny<string>()), Times.Once);
            _fryMock.Verify(a => a.BeStupid(), Times.Once);
        }
    }
}