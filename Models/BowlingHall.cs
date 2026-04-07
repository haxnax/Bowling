using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.Models
{
    public class BowlingHall
    {
        public int BowlingHallId { get; set; }
        public string BowlingHallName { get; set; }
        public ICollection<BowlingLane> BookingLanes { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}