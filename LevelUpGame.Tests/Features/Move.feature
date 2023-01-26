
Feature: Move in a direction

  I want to move my character. The move results in changing the current position of the character.
  
  
 @acceptance
 Scenario Outline: Move in a direction
   Given  the character starts at position with XCoordinates <startingPositionX>
   And starts at YCoordinates <startingPositionY>
   And the player choses to move in <direction>
   When the character moves
   Then the character is not at position with XCoordinates <endingPositionX>
   And YCoordinates <endingPositionY>
 
   Examples:
     | startingPositionX | starttingPositionY | direction | endingPositionX | endingPositionY |
     | 2 | 2 | NORTH | 2 | 3 |
