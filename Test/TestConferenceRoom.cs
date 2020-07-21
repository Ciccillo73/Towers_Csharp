using NUnit.Framework;

namespace Towers_cSharp
{
    public class TestConferenceRoom
    {
        private ConferenceRoom _conferenceRoom;
        private Guest _guest1;
        private Guest _guest2;
        private Guest _guest3;
        [SetUp]
        public void SetUp()
        {
            _conferenceRoom = new ConferenceRoom(20, "Eagle");
            _guest1 = new Guest("John");
            _guest2 = new Guest("Phil");
            _guest3 = new Guest("Frank");
        }

        [Test]
        public void Return_Capacity()
        {
            Assert.That(_conferenceRoom.Capacity, Is.EqualTo(20));
        }
    }
}