using System.Drawing; 

namespace levelup
{
    public class GameController
    {
        // TODO: If your stakeholder wants to call this CHARACTER, change var name for
        // low representational gap
        public readonly string DEFAULT_CHARACTER_NAME = "Character";

        public const int SizeX = 10;
        public const int SizeY = 10;




        public record struct GameStatus(
            // TODO: Add other status data
            String characterName,
            String playerName,
            Point currentPosition
        );

        // TODO: Ensure this AND CLI commands match domain model
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        GameStatus status = new GameStatus();

        public GameController()
        {
            status.characterName = DEFAULT_CHARACTER_NAME;
            status.currentPosition = new Point(-1,-1);
        }

        // Pre-implemented to demonstrate ATDD
        // TODO: Update this if it does not match your design
        public void CreateCharacter(String name)
        {
            if (name != null && !name.Equals(""))
            {
                this.status.characterName = name;
            }
            else
            {
                this.status.characterName = DEFAULT_CHARACTER_NAME;
            }
        }

        public void StartGame()
        {
            // TODO: Implement startGame - Should probably create tiles and put the character
            // on them?
            // TODO: Should also update the game status?
            Draw();

        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
            
        }

        public void SetCharacterPosition(Point coordinates){
            //TODO: Implement This to set charaters current position -- exists to be tested
        }


   public  string  Draw()
        {
            for (int y = SizeY -1; y >= 0; y--)
            {
                for(int x =0; x <SizeX; x++)
                {
                    Console.Write(" # ");

                }

                Console.Write('\n');
            }
return string.Empty;

        }

    }
}