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

        [TestMethod]
        public void TestChicagoNeighbors()
        {
            City chicago = new City();
            List<City> chicagoList = new List<City>();
            City sanFran = new City();
            City montreal = new City();
            City atlanta = new City();
            City mexicoCity = new City();
            City losAngeles = new City();
            chicagoList.Add(sanFran);
            chicagoList.Add(mexicoCity);
            chicagoList.Add(montreal);
            chicagoList.Add(atlanta);
            chicagoList.Add(losAngeles);
            chicago.setAdjacentCities(chicagoList);
            Assert.AreEqual(chicagoList, chicago.getAdjacentCities());
            
        }
    }
}
