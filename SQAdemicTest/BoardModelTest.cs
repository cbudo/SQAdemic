using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SQAdemic;
using Rhino.Mocks;

namespace SQAdemicTest
{
    [TestFixture()]
    class BoardModelTest
    {
        private SQAdemic.Models.GameBoardModels BoardModel;
        [Test()]
        public void TestThatBoardInitializes()
        {
            BoardModel = new SQAdemic.Models.GameBoardModels();
            int[] cubeExpected = {24,24,24,24};
            SQAdemic.Models.GameBoardModels.CURESTATE notCured = SQAdemic.Models.GameBoardModels.CURESTATE.NotCured;
            SQAdemic.Models.GameBoardModels.CURESTATE[] cures = { notCured, notCured, notCured, notCured };
            Assert.AreEqual(cubeExpected, BoardModel.getCubes());
            Assert.AreEqual(cures, BoardModel.getCures());
            
        }

    }
    
}
