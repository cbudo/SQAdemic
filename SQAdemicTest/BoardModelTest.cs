using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SQAdemic;

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
            Assert.AreEqual(cubeExpected, BoardModel.getCubes());
            
        }

    }
    
}
