using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using FluentAssertions;
using levelup;
using System.Drawing;

GameController testObj = new GameController();

int startX, startY, endX, endY;

GameController.DIRECTION direction;
Point currentPosition;