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
            List<SQAdemic.Models.City> sflist = new List<SQAdemic.Models.City>();
            SQAdemic.Models.City chicago =  new SQAdemic.Models.City();
            SQAdemic.Models.City losAngeles =  new SQAdemic.Models.City();
            SQAdemic.Models.City tokyo =  new SQAdemic.Models.City();
            SQAdemic.Models.City manila =  new SQAdemic.Models.City();
            sflist.Add(chicago);
            sflist.Add(losAngeles);
            sflist.Add(tokyo);
            sflist.Add(manila);
            //Assert.AreEqual(sflist, SQAdemic.Models.....how do this);

        }
    }
}
