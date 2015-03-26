using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQAdemic.Models
{
    public class GameBoardModels
    {
        enum color{ red, black, blue, yellow }
        enum cardType { Infection, Player, Special }
        enum cureState { NotCured, Cured, Sunset }
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
            public string CityName { get; set; }
            public cardType CardType { get; set; }
            public color CityColor { get; set; }

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
            public cureState RedCure { get; set; }
            public cureState BlueCure { get; set; }
            public cureState BlackCure { get; set; }
            public cureState YellowCure { get; set; }
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
            public void infectCity(string color, int numToAdd)
            {

            }

            public void cureCity(string color, int numToRemove)
            {

            }
        }
    }
}