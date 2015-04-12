using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SQAdemic.Models;

namespace CreateTest
{
    [TestClass]
    public class TestNeighbors
    {
        [TestMethod]
        public void TestSanFranNeighbors()
        {
            List<City> sflist = new List<City>();
            City sanFransisco = new City();
            City chicago =  new City();
            City losAngeles =  new City();
            City tokyo =  new City();
            City manila =  new City();
            sflist.Add(chicago);
            sflist.Add(losAngeles);
            sflist.Add(tokyo);
            sflist.Add(manila);
            sanFransisco.setAdjacentCities(sflist);
            Assert.AreEqual(sflist, sanFransisco.getAdjacentCities());

        }
    }
}
