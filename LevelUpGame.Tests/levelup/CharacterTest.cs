using levelup;
using NUnit.Framework;
using System;


namespace levelup{

  [TestFixture]
    public class CharacterTest{

            private Character? _testCharacter;


          // Default character Test
          [Test]
            public void initCharacterTest(){
              _testCharacter = new Character();

              Assert.AreEqual("Character",_testCharacter.NAME);             
            }

            
            [Test]
            public void getCharacterName()
            {
              _testCharacter = new Character("Sam");
              Assert.AreEqual(_testCharacter.NAME, _testCharacter.NAME);
            }

            [Test]
            public void getName()
            {
                GameController gamecontroller = new GameController();
                 
                levelup.GameController.GameStatus name= gamecontroller.GetStatus();
                 
                 Assert.AreEqual(name,name);

               


            }

            
    }
}

