using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQAdemic.Models
{
    public class GameBoardModels
    {
        infectionCubeCount cubeCount;
        Cures CURESTATUS;
        public GameBoardModels()
        {
            cubeCount = new infectionCubeCount();
            cubeCount.blackCubes = cubeCount.redCubes = cubeCount.blueCubes = cubeCount.yellowCubes = 24;
            CURESTATUS = new Cures();
            CURESTATUS.BlackCure = CURESTATUS.BlueCure = CURESTATUS.RedCure = CURESTATUS.YellowCure = CURESTATE.NotCured;
        }
        public int[] getCubes()
        {
            int[] cubes = { cubeCount.blackCubes, cubeCount.redCubes, cubeCount.blueCubes, cubeCount.yellowCubes };
            return cubes;
        }

        public enum COLOR{ red, black, blue, yellow }
        public enum CARDTYPE { Infection, Player, Special }
        public enum CURESTATE { NotCured, Cured, Sunset }

        public CURESTATE[] getCures()
        {
            CURESTATE[] cures = { CURESTATUS.BlackCure, CURESTATUS.BlueCure, CURESTATUS.RedCure, CURESTATUS.YellowCure };
            return cures;
        }

        public class onBoard
        {
            //stacks for infection and player deck
            Stack<Card> infectionDeck = new Stack<Card>();
            Stack<Card> PlayerDeck = new Stack<Card>();
            // discard Piles
            Card[] playerDiscardPile = new Card[60];
            Card[] infectionDiscardPile = new Card[48];
        }
        public class Card
        {
            public string CityName;
            CARDTYPE CardType {get;set;}
            COLOR CityColor { get; set; }

        }
        public class infectionCubeCount
        {
            public int redCubes { get; set; }
            public int blackCubes { get; set; }
            public int blueCubes { get; set; }
            public int yellowCubes { get; set; }
        }
        public class Cures
        {
            public CURESTATE RedCure{get;set;}
            public CURESTATE BlueCure { get; set; }
            public CURESTATE BlackCure { get; set; }
            public CURESTATE YellowCure { get; set; }
        }
    /**    public class City
        {
            public string Name;
            public string color;
            private int redCubes = 0;
            private int blackCubes = 0;
            private int blueCubes = 0;
            private int yellowCubes = 0;
            private bool researchStation = false;
            private List<City> adjacentCities;


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
        }**/
    }
}