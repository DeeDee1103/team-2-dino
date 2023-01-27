using NUnit.Framework;
using levelup;

namespace levelup{

    [TestFixture]
    public class GameMapTest
    {
        private GameMap? testGameMap;

          [SetUp]
        public void SetUp()
        {
            testGameMap = new GameMap();
        }

        [Test]
        public void IsGameMapInitialized()
        {
            
        }
    }
}