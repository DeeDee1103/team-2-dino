using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using FluentAssertions;
using levelup;
using System.Drawing;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class MoveSteps
    {
        private GameController testObj = new GameController();
        private int startX;
        private int startY;
        private int endX;
        private int endY;
        private GameController.DIRECTION direction;
        private Point currentPosition;

        // public MoveSteps(ScenarioContext scenarioContext)
        // { 
        //      //   _scenarioContext = scenarioContext;
        // }

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

        [Then(@"the character is now at position with XCoordinates(.*)")]
        public void checkXCoordinates(int endX)
        {
          Assert.NotNull(this.currentPosition, "Expected position not null");
          Assert.AreEqual(endX, this.currentPosition.X);
        }

        [Then(@"YCoordinates (.*)")]
        public void checkYCoordinates(int endY)
        {
          Assert.NotNull(this.currentPosition, "Expected position not null");
          Assert.AreEqual(endY, this.currentPosition.Y);
        }
    }

  
}
