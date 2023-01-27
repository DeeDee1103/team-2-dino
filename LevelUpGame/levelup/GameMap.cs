using System.Drawing; 

namespace levelup
{
    public class GameMap
    {
        public Position[][] positions {get; set;}
        public Position startingPosition = 0,0;
        public int numPositions = 100;
    }
}