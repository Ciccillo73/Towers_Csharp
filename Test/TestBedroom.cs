using NUnit.Framework;

namespace Towers_cSharp
{
    public class Test
    {
        private Bedroom _bedroom;
        private Guest _guest1;  

        [SetUp]
        public void Setup()
        {
            _bedroom = new Bedroom(32, 5, "Double", 25.00);
            _guest1 = new Guest("John");   
        }
        

       [Test]
       [Ignore("Learning purposes")]
       public void Return_RoomNumber()
       {
           var result = _bedroom.RoomNumber;
            Assert.That(result, Is.EqualTo(32));
       }

       [Test]
       public void Return_RoomCapacity()
       {
           var result = _bedroom.Capacity;
           Assert.That(result, Is.EqualTo(5));
       }

       [Test]
       public void Return_RoomType()
       {
           var result = _bedroom.Type;
           Assert.That(result, Is.EqualTo("Double"));
       }

       [Test]
       public void Return_NightlyRate()
       {
           var result = _bedroom.NightlyRate;
           Assert.That(result, Is.EqualTo(25.00));
       }

       [Test]
       public void Return_GuestListSize_MustBeEmpty()
       {
           var result = _bedroom.countGuestList();
           Assert.That(result, Is.EqualTo(0));
       }

       [Test]
       public void Add_WhenCalled_ReturnTheListSize()
       {
           _bedroom.checkInGuests(_guest1);
           var result = _bedroom.countGuestList();
           Assert.That(result, Is.EqualTo(1));
       }

       [Test]
       public void Add_WhenCalled_ReturnClearList()
       {
           _bedroom.checkOutGuests();
           var result = _bedroom.countGuestList();
           Assert.That(result, Is.EqualTo(0));
       }
    }
}