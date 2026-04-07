using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bowling.Models
{
    public class BowlingLane
    {
        public int BowlingLaneId { get; set; }
        public bool IsAvailable { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public int BowlingHallId { get; set; }

        public int GameId { get; set; }
        public ICollection<Game> games { get; set; }
    }
}