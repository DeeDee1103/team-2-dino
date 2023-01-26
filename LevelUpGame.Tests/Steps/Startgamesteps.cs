using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using FluentAssertions;
using levelup;
using System.Drawing;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class CreateGameSteps
    {

GameController testObj = new GameController();

int startX, startY, endX, endY;

GameController.DIRECTION direction;
Point currentPosition;
    }
}
[Given(@"the character starts at position with XCoordinates(.*)")]
        public void givenTheCharacterStartsAtX(int startX)
        {
          this.startX = startX;
        }

        [Given(@"starts at YCoordinates (.*)")]
        public void givenTheCharaterStartsAtY(int startY)
        {
          this.startY = startY;
        }

        [Given(@"the player chooses to move in (.*)")]
        public void givenPlayerChoosesDirection(String direction)
        {
          this.direction = (GameController.DIRECTION)
          Enum.Parse(typeof(GameController.DIRECTION), direction);
        }
  
        [When(@"the character moves")]
        public void whenTheCharacterMoves()
        {
          testObj.SetCharacterPosition(new Point(this.startX, this.startY));
          testObj.Move(this.direction);
          GameController.GameStatus status = testObj.GetStatus();
          this.currentPosition = status.currentPosition = status.currentPosition;
        }
        