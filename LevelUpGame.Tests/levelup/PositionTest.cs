using NUnit.Framework;
using levelup;
using System.Drawing; 

namespace levelup{

    [TestFixture]
    public class PositionTest
    {
        private Position? testPosition;

          [SetUp]
        public void SetUp()
        {
            testPosition = new Position(1,1);
        }

        [Test]
        public void IsPositionInitialized()
        {
            Assert.AreEqual(testPosition.coordinates, new Point(1,1));
        }
    }
    
}