using NUnit.Framework;

namespace Towers_cSharp
{
    public class TestBooking
    {

        private Booking _booking;
        private Bedroom _bedroom;
        
        [SetUp]
        public void SetUp()
        {
            _booking = new Booking(2,_bedroom);
            _bedroom = new Bedroom(2, 4, "Double", 25.00);
        }

        [Test]
        public void CheckNumberOfNight_Return_numberOfNights()
        {
            var result = _booking.NumberOfNights;
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Return_Double_Bill()
        {
            var result = _booking.totalBill();
            Assert.That(result, Is.EqualTo(50));
        }
            
        
    }
}