using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using FluentAssertions;
using levelup;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class MoveSteps
    {
        GameController testObj = new GameController();
        int startX, startY, endX, endY;
        GameController.DIRECTION direction;
        Point currentPosition;
    }

    [Given(@"the character starts at position with XCoordinates(.*)")]
    public void givenTheCharacterStartsAtX(int startX)
    {
      this.startX = null;
    }

  [Given(@"starts at YCoordinates (.*)")]
  public void givenTheCharaterStartsAtY(int startY)
  {
    this.startY = startY;
  }

  [Given(@"the ")]
}
