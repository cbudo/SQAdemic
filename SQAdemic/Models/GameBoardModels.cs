using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQAdemic.Models
{
    public class GameBoardModels
    {
        enum cureState
        {
            NotCured,Cured,Sunset
        }
        public class Cures
        {
            public cureState RedCure {get;set;}
            public cureState BlueCure {get;set;}
            public cureState BlackCure {get;set;}
            public cureState YellowCure {get;set;}
        }
        public class City
        {
            public string Name { get; }
            private int redCubes = 0;
            private int blackCubes = 0;
            private int blueCubes = 0;
            private int yellowCubes = 0;
            private bool researchStation = false;
            private List<City> AdjacentCities;
            public void infectCity(string color,int numToAdd)
            {
                
            }
            
            public void cureCity(string color, int numToRemove)
            {
                
            }
        }
    }
}