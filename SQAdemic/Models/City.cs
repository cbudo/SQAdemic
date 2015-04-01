﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SQAdemic.Models;

namespace SQAdemic.Models
{
    public class City
    {
        public string Name;
        public GameBoardModels.COLOR color;
        private int redCubes = 0;
        private int blackCubes = 0;
        private int blueCubes = 0;
        private int yellowCubes = 0;
        private bool researchStation = false;
        private List<City> adjacentCities;

        public City(GameBoardModels.COLOR color)
        {
            this.color = color;
        }

        public void setAdjacentCities(List<City> cities)
        {
            this.adjacentCities = cities;
        }

        public List<City> getAdjacentCities()
        {
            return adjacentCities;
        }

        public void infectCity(string color, int numToAdd)
        {

        }

        public void cureCity(string color, int numToRemove)
        {

        }
    }
}