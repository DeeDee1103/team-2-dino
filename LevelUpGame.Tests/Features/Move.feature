
Feature: Move in a direction

  I want to move my character. The move results in changing the current position of the character.
  
  
 @acceptance
 Scenario Outline: Move in a direction
   Given  the character starts at position with XCoordinates <startingPositionX>
   And starts at YCoordinates <startingPositionY>
   And the player chooses to move in <direction>
   When the character moves
   Then the character is not at position with XCoordinates <endingPositionX>
   And YCoordinates <endingPositionY>
 
   Examples:
     | startingPositionX | starttingPositionY | direction | endingPositionX | endingPositionY |
     | 0 | 0 | NORTH | 0 | 1 |
     | 0 | 0 | SOUTH | 0 | 0 |
     | 0 | 0 | WEST | 0 | 0 |
     | 0 | 0 | EAST | 1 | 0 |
     | 10 | 0 | NORTH | 10 | 1 |
     | 10 | 0 | SOUTH | 10 | 0 |
     | 10 | 0 | WEST | 9 | 0 |
     | 10 | 0 | EAST | 10 | 0 |
     | 10 | 10 | NORTH | 10 | 10 |
     | 10 | 10 | SOUTH | 10 | 9 |
     | 10 | 10 | WEST | 9 | 10 |
     | 10 | 10 | EAST | 10 | 10 |
     | 0 | 10 | NORTH | 0 | 10 |
     | 0 | 10 | SOUTH | 0 | 9 |
     | 0 | 10 | WEST | 0 | 10 |
     | 0 | 10 | EAST | 1 | 10 |
     | 3 | 4 | NORTH | 3 | 5 |
     | 3 | 4 | SOUTH | 3 | 3 |
     | 3 | 4 | WEST | 2 | 4 |
     | 3 | 4 | EAST | 4 | 4 |
     | 0 | 7 | NORTH | 0 | 8 |
     | 0 | 7 | SOUTH | 0 | 6 |
     | 0 | 7 | WEST | 0 | 7 |
     | 0 | 7 | EAST | 1 | 7 |
     | 10 | 2 | NORTH | 10 | 3 |
     | 10 | 2 | SOUTH | 10 | 1 |
     | 10 | 2 | WEST | 9 | 2 |
     | 10 | 2 | EAST | 10 | 2 |
     | 5 | 10 | NORTH | 5 | 10 |
     | 5 | 10 | SOUTH | 5 | 9 |
     | 5 | 10 | WEST | 4 | 10 |
     | 5 | 10 | EAST | 6 | 10 |
     | 5 | 0 | NORTH | 5 | 1 |
     | 5 | 0 | SOUTH | 5 | 0 |
     | 5 | 0 | WEST | 4 | 0 |
     | 5 | 0 | EAST | 6 | 0 |

