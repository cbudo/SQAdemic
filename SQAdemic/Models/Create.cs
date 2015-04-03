﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SQAdemic.Models;

namespace SQAdemic.Models
{
    public class Create
    {
        //create the blues
        City sanFrancisco = new City(GameBoardModels.COLOR.blue);
        City chicago = new City(GameBoardModels.COLOR.blue);
        City montreal = new City(GameBoardModels.COLOR.blue);
        City newYork = new City(GameBoardModels.COLOR.blue);
        City washington = new City(GameBoardModels.COLOR.blue);
        City atlanta = new City(GameBoardModels.COLOR.blue);
        City london = new City(GameBoardModels.COLOR.blue);
        City madrid = new City(GameBoardModels.COLOR.blue);
        City paris = new City(GameBoardModels.COLOR.blue);
        City milan = new City(GameBoardModels.COLOR.blue);
        City stPetersburg = new City(GameBoardModels.COLOR.blue);
        City essen = new City(GameBoardModels.COLOR.blue);

        //create the yellows
        City losAngeles = new City(GameBoardModels.COLOR.yellow);
        City mexicoCity = new City(GameBoardModels.COLOR.yellow);
        City miami = new City(GameBoardModels.COLOR.yellow);
        City bogota = new City(GameBoardModels.COLOR.yellow);
        City lima = new City(GameBoardModels.COLOR.yellow);
        City saoPaulo = new City(GameBoardModels.COLOR.yellow);
        City buenosAires = new City(GameBoardModels.COLOR.yellow);
        City santiago = new City(GameBoardModels.COLOR.yellow);
        City lagos = new City(GameBoardModels.COLOR.yellow);
        City khartoum = new City(GameBoardModels.COLOR.yellow);
        City kinshasa = new City(GameBoardModels.COLOR.yellow);
        City johannesburg = new City(GameBoardModels.COLOR.yellow);

        //create the blacks
        City algiers = new City(GameBoardModels.COLOR.black);
        City cairo = new City(GameBoardModels.COLOR.black);
        City istanbul = new City(GameBoardModels.COLOR.black);
        City moscow = new City(GameBoardModels.COLOR.black);
        City baghdad = new City(GameBoardModels.COLOR.black);
        City riyadh = new City(GameBoardModels.COLOR.black);
        City tehran = new City(GameBoardModels.COLOR.black);
        City karachi = new City(GameBoardModels.COLOR.black);
        City delhi = new City(GameBoardModels.COLOR.black);
        City mumbai = new City(GameBoardModels.COLOR.black);
        City chennai = new City(GameBoardModels.COLOR.black);
        City kolkata = new City(GameBoardModels.COLOR.black);

        //create the reds
        City beijing = new City(GameBoardModels.COLOR.red);
        City seoul = new City(GameBoardModels.COLOR.red);
        City shanghai = new City(GameBoardModels.COLOR.red);
        City tokyo = new City(GameBoardModels.COLOR.red);
        City osaka = new City(GameBoardModels.COLOR.red);
        City taipei = new City(GameBoardModels.COLOR.red);
        City hongKong = new City(GameBoardModels.COLOR.red);
        City bangkok = new City(GameBoardModels.COLOR.red);
        City manila = new City(GameBoardModels.COLOR.red);
        City hoChiMinhCity = new City(GameBoardModels.COLOR.red);
        City jakarta = new City(GameBoardModels.COLOR.red);
        City sydney = new City(GameBoardModels.COLOR.red);
    }
    public class createDeck
    {
        GameBoardModels boardModel;
        List<GameBoardModels.Card> cities;
        public createDeck(GameBoardModels boardModel, List<GameBoardModels.Card> cities)
        {
            this.boardModel = boardModel;
            this.cities = cities;
        }
        public void makePlayerDeck()
        {
            var rand = new Random();
            List<GameBoardModels.Card> shuffled = (List<GameBoardModels.Card>) cities.OrderBy(item => rand.Next()).Select(x => x).ToList<GameBoardModels.Card>();
            // sort in Epidemic cards - attempt to evenly distribute
            GameBoardModels.Card EpidemicCard = new GameBoardModels.Card("EPIDEMIC", GameBoardModels.CARDTYPE.Player);
            boardModel.playerDeck[rand.Next(0, 9)] = EpidemicCard;
            boardModel.playerDeck[rand.Next(10, 20)] = EpidemicCard;
            boardModel.playerDeck[rand.Next(31, 41)] = EpidemicCard;
            boardModel.playerDeck[rand.Next(42, 52)] = EpidemicCard;
            boardModel.playerDeck[rand.Next(53, 57)] = EpidemicCard;
            while(shuffled.Count <= 53)
            {
                shuffled.Add(new GameBoardModels.Card("NULL", GameBoardModels.CARDTYPE.Player));
            }
            int j = 0; // index shuffled
            for (int i = 0; i < 58; i++ )
            {
                if (boardModel.playerDeck[i] == null)
                {
                    boardModel.playerDeck[i] = shuffled[j];
                    j++;
                }
            }
        }
        
    }
}