using NUnit.Framework;

namespace Towers_cSharp
{
    public class Test
    {
        private  Bedroom _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Bedroom("Pink");
        }
        

       [Test]
       public void Test1()
       {
            Assert.That("Pink", Is.EqualTo(_sut.Name));
       }
        
        [Test]
        public 
             
    }
}