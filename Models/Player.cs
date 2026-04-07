using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int RoundId { get; set; }
        public Game Game { get; set; }

        public int TotalScore { get
            {

               return TotalScore += Game.Score;
                
            } set; }

       
    }
}
