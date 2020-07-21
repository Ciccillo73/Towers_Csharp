using NUnit.Framework;

namespace Towers_cSharp
{
    public class TestHotel
    {

        private Hotel _hotel;
        private Bedroom _singleBedroom;
        private Bedroom _doubleBedroom;
        private DiningRoom _diningRoom;
        private ConferenceRoom _conferenceRoom;
        private Guest _guest1;
        private Guest _guest2;
        private Guest _guest3;
        
        [SetUp]
        public void Setup()
        {
            _hotel = new Hotel();
            _singleBedroom = new Bedroom(1,2,"single", 25.00);
            _doubleBedroom = new Bedroom(2,3,"double", 40.00);
            _diningRoom = new DiningRoom("Heaven");
            _conferenceRoom = new ConferenceRoom(10, "BigMess");
            _guest1 = new Guest("John");
            _guest2 = new Guest("Paul");
            _guest3 = new Guest("Steve");
            _hotel.addBedroom(_singleBedroom);
            _hotel.addBedroom(_doubleBedroom);
            _hotel.addConferenceRoom(_conferenceRoom);
            _hotel.addDiningRoom(_diningRoom);
        }
    }
}