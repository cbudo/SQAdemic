﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SQAdemic.Models.GameBoardModels;

namespace SQAdemic.Models
{
    public class PlayerModels
    {
        public class Player
        {
            public List<GameBoardModels.Card> hand = new List<GameBoardModels.Card>();
            public GameBoardModels.City location { get; set; }
            public Player()
            {
                    
            }
            public void move(GameBoardModels.City destination)
            {

            }
        }
        public class Medic : Player
        {
            public Medic()
            {

            }
        }
        public class OpExpert : Player
        {
            public OpExpert()
            {

            }
        }
        public class Researcher : Player
        {
            public Researcher()
            {

            }
        }
        public class Scientist : Player
        {
            public Scientist()
            {

            }
        }
        public class Dispatcher :Player
        {
            public Dispatcher()
            {

            }
        }
        
    }
}