using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CreateTest
{
    [TestClass]
    public class TestNeighbors
    {
        [TestMethod]
        public void TestSanFranNeighbors()
        {
            List<SQAdemic.Models.GameBoardModels.City> sflist = new List<SQAdemic.Models.GameBoardModels.City>();
            SQAdemic.Models.GameBoardModels.City chicago =  new SQAdemic.Models.GameBoardModels.City();
            SQAdemic.Models.GameBoardModels.City losAngeles =  new SQAdemic.Models.GameBoardModels.City();
            SQAdemic.Models.GameBoardModels.City tokyo =  new SQAdemic.Models.GameBoardModels.City();
            SQAdemic.Models.GameBoardModels.City manila =  new SQAdemic.Models.GameBoardModels.City();
            sflist.Add(chicago);
            sflist.Add(losAngeles);
            sflist.Add(tokyo);
            sflist.Add(manila);
            //Assert.AreEqual(sflist, SQAdemic.Models.....how do this);

        }
    }
}
