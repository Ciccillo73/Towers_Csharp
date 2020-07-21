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
            _conferenceRoom = new ConferenceRoom(1, "Eagle");
            _guest1 = new Guest("John");
            _guest2 = new Guest("Phil");
            _guest3 = new Guest("Frank");
        }

        [Test]
        public void Return_Capacity()
        {
            Assert.That(_conferenceRoom.Capacity, Is.EqualTo(20));
        }

        [Test]
        public void Return_Name()
        {
            Assert.That(_conferenceRoom.Name,Is.EqualTo("Eagle"));
        }

        [Test]
        public void Return_Int_GuestListSize()
        {
            Assert.That(_conferenceRoom.guestListSize(), Is.EqualTo(0));
        }

        [Test]
        public void Add_Guests_Return_Number_Of_Guests()
        {
            _conferenceRoom.checkinGuest(_guest1);
            _conferenceRoom.checkinGuest(_guest2);
            Assert.That(_conferenceRoom.guestListSize(), Is.EqualTo(2));
        }

        [Test]
        public void AddGuest_ClearGuest_ReturnNumberOfGuests()
        {
            _conferenceRoom.checkinGuest(_guest1);
            _conferenceRoom.checkinGuest(_guest2);
            _conferenceRoom.checkOutGuests();
            Assert.That(_conferenceRoom.guestListSize(), Is.EqualTo(0));
        }

        [Test]
        public void CheckInGuestOverCapacity_ReturnMaxCapacity()
        {
            _conferenceRoom.checkinGuest(_guest1);
            _conferenceRoom.checkinGuest(_guest2);
            Assert.That(_conferenceRoom.guestListSize(), Is.EqualTo(1));
        }
    }
}