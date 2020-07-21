using NUnit.Framework;

namespace Towers_cSharp
{
    public class Test
    {
        private  Bedroom _bedroom;

        [SetUp]
        public void Setup()
        {
            _bedroom = new Bedroom(32, 5, "Double", 25.00);
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
        
         
             
    }
}