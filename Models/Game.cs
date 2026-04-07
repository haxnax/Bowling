using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bowling.Models
{
    public class Game
    {
        public int GameId { get; set; }
       public int BowlingLaneId { get; set; }
        public int NumberOfGame { get; set; } = 1;
        public int NumberOfRounds { get; set; }
        public int PlayerId { get; set; }
        public int Score { get; set; }
        public int TotalScore
        {
            get
            {
                if (NumberOfRounds >= 10)
                    return TotalScore += Score;
                else { return NumberOfRounds = 0;
                    NumberOfGame++;
                }

            } set;
        }
    }
}
