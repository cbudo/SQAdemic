using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQAdemic.Models;
using Rhino.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SQAdemicTest
{
    [TestClass]
    public class BoardModelTest
    {
        private SQAdemic.Models.GameBoardModels BoardModel;
        [TestMethod]
        public void TestThatBoardInitializes()
        {
            BoardModel = new SQAdemic.Models.GameBoardModels();
            int[] cubeExpected = {24,24,24,24};
            SQAdemic.Models.GameBoardModels.CURESTATE notCured = SQAdemic.Models.GameBoardModels.CURESTATE.NotCured;
            SQAdemic.Models.GameBoardModels.CURESTATE[] cures = { notCured, notCured, notCured, notCured };
            NUnit.Framework.Assert.AreEqual(cubeExpected, BoardModel.getCubes());
            NUnit.Framework.Assert.AreEqual(cures, BoardModel.getCures());
            
        }
        [TestMethod]
        public void TestThatPlayerDrawsCard()
        {
            List<GameBoardModels.Card> cities = new List<GameBoardModels.Card>();
            cities.Add(new GameBoardModels.Card("CityName", GameBoardModels.CARDTYPE.Player));
            //createDeck deckCreator = new createDeck(BoardModel,cities);
            //deckCreator.makePlayerDeck();
            NUnit.Framework.Assert.AreNotEqual(null, BoardModel.drawCard());

        }

    }
    [TestClass]
    public class testPlayers
    {
        private SQAdemic.Models.GameBoardModels BoardModel = new SQAdemic.Models.GameBoardModels();
         [TestMethod]
         public void TestThatPlayerDrawsCard()
            {
                List<GameBoardModels.Card> cities = new List<GameBoardModels.Card>();
                cities.Add(new GameBoardModels.Card("CityName", GameBoardModels.CARDTYPE.Player));
               // createDeck deckCreator = new createDeck(BoardModel,cities);
                //deckCreator.makePlayerDeck();
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(null, BoardModel.drawCard());
             
            }
    }
    
    
}
