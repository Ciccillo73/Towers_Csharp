using NUnit.Framework;

namespace Towers_cSharp
{
    public class TestDiningRoom
    {
        private DiningRoom _diningRoom;
        private Guest _guest1;
        private Guest _guest2;
        
        
        [SetUp]
        public void SetUp()
        {
            _diningRoom = new DiningRoom("Heaven");
            _guest1 = new Guest("Phil");
            _guest2 = new Guest("MArk");
        }

        [Test]
        public void Return_Name()
        {
            Assert.That(_diningRoom.Name, Is.EqualTo("Heaven"));
        }

        [Test]
        public void ReturnGuestListStartsAtZero()
        {
            Assert.That(_diningRoom.guestListSize(), Is.EqualTo(0));
        } 
    }
}